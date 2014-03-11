using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class Status
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }


    public class Status2
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}