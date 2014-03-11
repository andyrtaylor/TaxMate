using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class AccountDisplayName
    {
        [JsonProperty("defaultNormalAccountName")]
        public string DefaultNormalAccountName { get; set; }
    }
}