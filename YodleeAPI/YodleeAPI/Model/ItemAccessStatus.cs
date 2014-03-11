using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ItemAccessStatus
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}