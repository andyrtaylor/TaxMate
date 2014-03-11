using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class RepsonseItemSummaries
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("contentServiceId")]
        public int ContentServiceId { get; set; }

        [JsonProperty("contentServiceInfo")]
        public ContentServiceInfo ContentServiceInfo { get; set; }

        [JsonProperty("itemDisplayName")]
        public string ItemDisplayName { get; set; }

        [JsonProperty("refreshInfo")]
        public RefreshInfo RefreshInfo { get; set; }

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("itemData")]
        public ItemData ItemData { get; set; }

        [JsonProperty("itemStatus")]
        public int ItemStatus { get; set; }

        [JsonProperty("isHeld")]
        public int IsHeld { get; set; }

        [JsonProperty("isSharedItem")]
        public bool IsSharedItem { get; set; }

        [JsonProperty("isPrepop")]
        public bool IsPrepop { get; set; }

        [JsonProperty("memSiteAccId")]
        public int MemSiteAccId { get; set; }
    }
}
