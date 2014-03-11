using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Type2
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}