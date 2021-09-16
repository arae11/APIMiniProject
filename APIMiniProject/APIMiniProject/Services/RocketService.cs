using APIMiniProject.Data;
using APIMiniProject.HTTPManager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APIMiniProject.HTTPManager
{
    class RocketService
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<RocketResponse> RocketResponseDTO { get; set; }
        public string RocketSelected { get; set; }
        public string RocketResponse { get; set; }

        public RocketService()
        {
            CallManager = new CallManager();
            RocketResponseDTO = new DTO<RocketResponse>();
        }

        public async Task MakeRequestAsync(string rocketId)
        {
            RocketSelected = rocketId;
            RocketResponse = await CallManager.MakeRocketRequestAsync(rocketId);
            JsonResponse = JObject.Parse(RocketResponse);
            RocketResponseDTO.Deserialize(RocketResponse);
        }
    }
}
