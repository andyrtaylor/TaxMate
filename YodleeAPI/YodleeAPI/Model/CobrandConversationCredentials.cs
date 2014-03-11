using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class CobrandConversationCredentials
    {
        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }
}