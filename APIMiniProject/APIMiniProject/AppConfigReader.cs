using System.Configuration; //Allows us to access the app.config file

namespace APIMiniProject
{
    class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
