using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ResponseCodeType
    {
        [JsonProperty("responseCodeTypeId")]
        public int ResponseCodeTypeId { get; set; }
    }
}