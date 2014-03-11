using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class NumberFormat
    {
        [JsonProperty("decimalSeparator")]
        public string DecimalSeparator { get; set; }

        [JsonProperty("groupingSeparator")]
        public string GroupingSeparator { get; set; }

        [JsonProperty("groupPattern")]
        public string GroupPattern { get; set; }
    }
}