using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class LastDataUpdateAttempt
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }
    }
}