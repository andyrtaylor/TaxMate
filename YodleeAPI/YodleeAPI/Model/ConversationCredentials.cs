using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ConversationCredentials
    {
        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }
}