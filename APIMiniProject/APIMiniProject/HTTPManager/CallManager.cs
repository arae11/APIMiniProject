using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace APIMiniProject.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;

        public int StatusCode { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public CallManager(string uri)
        {
            _client = new RestClient(uri);
        }

        public async Task<string> MakeStarLinkRequest(string sateliteID)
        {
            //set up the request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            //define the request resource path
            request.Resource = $"/starlink/{sateliteID}";

            //Make request, (doesn't instantiate the interface. Just uses as type
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }
    }
}
