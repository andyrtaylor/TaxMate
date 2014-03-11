using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class LastPaymentDate
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("localFormat")]
        public string LocalFormat { get; set; }
    }

}