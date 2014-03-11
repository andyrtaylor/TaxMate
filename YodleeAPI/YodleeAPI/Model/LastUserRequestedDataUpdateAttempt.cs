using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class LastUserRequestedDataUpdateAttempt
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public Status2 Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("type")]
        public Type2 Type { get; set; }
    }
}