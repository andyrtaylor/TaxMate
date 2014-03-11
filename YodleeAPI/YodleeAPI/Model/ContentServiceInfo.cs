using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ContentServiceInfo
    {
        [JsonProperty("contentServiceId")]
        public int ContentServiceId { get; set; }
    }
}