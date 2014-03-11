using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class CurrentBalance
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}