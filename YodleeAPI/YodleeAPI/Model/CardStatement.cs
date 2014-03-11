using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class CardStatement
    {
        [JsonProperty("srcElementId")]
        public string SrcElementId { get; set; }

        [JsonProperty("isSeidMod")]
        public int IsSeidMod { get; set; }

        [JsonProperty("isSeidFromDataSource")]
        public int IsSeidFromDataSource { get; set; }

        [JsonProperty("billId")]
        public int BillId { get; set; }

        [JsonProperty("cardStatementId")]
        public int CardStatementId { get; set; }

        [JsonProperty("cardAccountId")]
        public int CardAccountId { get; set; }

        [JsonProperty("isDeleted")]
        public int IsDeleted { get; set; }

        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }

        [JsonProperty("hasDetails")]
        public int HasDetails { get; set; }

        [JsonProperty("cashAdvance")]
        public CashAdvance CashAdvance { get; set; }

        [JsonProperty("availableCredit")]
        public AvailableCredit2 AvailableCredit { get; set; }

        [JsonProperty("availableCash")]
        public AvailableCash2 AvailableCash { get; set; }

        [JsonProperty("totalCreditLine")]
        public TotalCreditLine2 TotalCreditLine { get; set; }

        [JsonProperty("totalCashLimit")]
        public TotalCashLimit2 TotalCashLimit { get; set; }

        [JsonProperty("apr")]
        public double Apr { get; set; }

        [JsonProperty("tranListToDate")]
        public TranListToDate2 TranListToDate { get; set; }

        [JsonProperty("tranListFromDate")]
        public TranListFromDate2 TranListFromDate { get; set; }

        [JsonProperty("cacheItemId")]
        public int CacheItemId { get; set; }

        [JsonProperty("isItemAccountDeleted")]
        public int IsItemAccountDeleted { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("itemAccountId")]
        public int ItemAccountId { get; set; }

        [JsonProperty("baseTagDataId")]
        public string BaseTagDataId { get; set; }

        [JsonProperty("refreshTime")]
        public int RefreshTime { get; set; }
    }
}