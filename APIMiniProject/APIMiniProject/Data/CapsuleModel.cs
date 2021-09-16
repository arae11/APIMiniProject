using Newtonsoft.Json;


namespace APIMiniProject.Data
{

    public class CapsuleResponse : IResponse
    {
        public int reuse_count { get; set; }
        public int water_landings { get; set; }
        public int land_landings { get; set; }
        public string last_update { get; set; }
        public string[] launches { get; set; }
        public string serial { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string id { get; set; }
    }

}
