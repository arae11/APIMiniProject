using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMiniProject.Data;
using APIMiniProject.HTTPManager;
using Newtonsoft.Json.Linq;

namespace APIMiniProject.Services
{
	public class CrewService
	{
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<CrewResponse> CrewResponseDTO { get; set; }
        public string CrewSelected { get; set; }
        public string CrewResponse { get; set; }

        public CrewService()
        {
            CallManager = new CallManager();
            CrewResponseDTO = new DTO<CrewResponse>();
        }

        public async Task MakeRequestAsync(string crewId)
        {
            CrewSelected = crewId;
            CrewResponse = await CallManager.MakeCrewRequestAsync(crewId);

            JsonResponse = JObject.Parse(CrewResponse);

            CrewResponseDTO.Deserialize(CrewResponse);
        }

        
    }
}
