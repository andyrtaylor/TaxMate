
using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class CurrencyNotationType
    {
        [JsonProperty("currencyNotationType")]
        public string CurrencyNotation { get; set; }
    }
}
