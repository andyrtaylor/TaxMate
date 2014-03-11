using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class TotalCashLimit
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class TotalCashLimit2
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}