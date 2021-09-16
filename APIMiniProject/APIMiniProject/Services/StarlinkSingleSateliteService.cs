using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APIMiniProject.Data;
using System.Threading.Tasks;
using APIMiniProject.HTTPManager;
using Newtonsoft.Json.Linq;

namespace APIMiniProject.Services
{
    class StarlinkSingleSateliteService
    {
        #region Properties
        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }
        public DTO<StarlinkSingleResponse> SingleStarlinkDTO { get; set; }
        public string SateliteSelected { get; set; }
        public string StarlinkResponse { get; set; }
        #endregion

        public StarlinkSingleSateliteService()
        {
            CallManager = new CallManager();
            SingleStarlinkDTO = new DTO<StarlinkSingleResponse>();

        }

        public async Task MakeRequestAsync(string sateliteID)
        {
            StarlinkResponse = await CallManager.MakeStarLinkRequestAsync(sateliteID);
            SateliteSelected = sateliteID;
            if (CallManager.StatusCode == 200)
            {
                Json_Response = JObject.Parse(StarlinkResponse);
                SingleStarlinkDTO.Deserialize(StarlinkResponse);
            }
            
        }

    }
}
