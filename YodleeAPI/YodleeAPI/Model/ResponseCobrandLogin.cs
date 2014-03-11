using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ResponseCobrandLogin
    {
        [JsonProperty("cobrandId")]
        public int CobrandId { get; set; }

        [JsonProperty("channelId")]
        public int ChannelId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("tncVersion")]
        public int TncVersion { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("cobrandConversationCredentials")]
        public CobrandConversationCredentials CobrandConversationCredentials { get; set; }

        [JsonProperty("preferenceInfo")]
        public PreferenceInfo PreferenceInfo { get; set; }
    }
}
