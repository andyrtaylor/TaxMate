using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ItemData
    {
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }
    }
}