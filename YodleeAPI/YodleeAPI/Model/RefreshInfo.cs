using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class RefreshInfo
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("refreshType")]
        public int RefreshType { get; set; }

        [JsonProperty("refreshRequestTime")]
        public int RefreshRequestTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public int LastUpdatedTime { get; set; }

        [JsonProperty("lastUpdateAttemptTime")]
        public int LastUpdateAttemptTime { get; set; }

        [JsonProperty("itemAccessStatus")]
        public ItemAccessStatus ItemAccessStatus { get; set; }

        [JsonProperty("userActionRequiredType")]
        public UserActionRequiredType UserActionRequiredType { get; set; }

        [JsonProperty("userActionRequiredCode")]
        public int UserActionRequiredCode { get; set; }

        [JsonProperty("userActionRequiredSince")]
        public string UserActionRequiredSince { get; set; }

        [JsonProperty("lastDataUpdateAttempt")]
        public LastDataUpdateAttempt LastDataUpdateAttempt { get; set; }

        [JsonProperty("lastUserRequestedDataUpdateAttempt")]
        public LastUserRequestedDataUpdateAttempt LastUserRequestedDataUpdateAttempt { get; set; }

        [JsonProperty("lastSuccessfulDataUpdate")]
        public string LastSuccessfulDataUpdate { get; set; }

        [JsonProperty("itemCreateDate")]
        public string ItemCreateDate { get; set; }

        [JsonProperty("nextUpdateTime")]
        public int NextUpdateTime { get; set; }

        [JsonProperty("responseCodeType")]
        public ResponseCodeType ResponseCodeType { get; set; }

        [JsonProperty("retryCount")]
        public int RetryCount { get; set; }

        [JsonProperty("refreshMode")]
        public string RefreshMode { get; set; }
    }

}