using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class PreferenceInfo
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("currencyNotationType")]
        public CurrencyNotationType CurrencyNotationType { get; set; }

        [JsonProperty("numberFormat")]
        public NumberFormat NumberFormat { get; set; }
    }
}