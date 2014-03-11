using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class AvailableCredit
    {

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class AvailableCredit2
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}