using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class TotalCreditLine
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class TotalCreditLine2
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}