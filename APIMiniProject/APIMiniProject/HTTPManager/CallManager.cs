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


    }
}
