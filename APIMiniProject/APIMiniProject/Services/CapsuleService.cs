using APIMiniProject.Data;
using APIMiniProject.HTTPManager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMiniProject.Services
{
    public class CapsuleService
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<CapsuleResponse> CapsuleResponseDTO { get; set; }
        public string CapsuleSelected { get; set; }
        public string CapsuleResponse { get; set; }

        public CapsuleService()
        {
            CallManager = new CallManager();
            CapsuleResponseDTO = new DTO<CapsuleResponse>();
        }

        public async Task MakeRequestAsync(string capsuleID)
        {
            CapsuleSelected = capsuleID;
            CapsuleResponse = await CallManager.MakeCapsuleRequestAsync(capsuleID);

            if (CallManager.StatusCode == 200)
            {
                JsonResponse = JObject.Parse(CapsuleResponse);
                CapsuleResponseDTO.Deserialize(CapsuleResponse);
            }
        }

        public int GetLaunches()
        {
            if (CapsuleResponseDTO.Response != null)
            {
                return CapsuleResponseDTO.Response.launches.Length;
            }
            throw new InvalidOperationException("Please make a valid request first");
        }

    }
}
