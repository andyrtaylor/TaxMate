using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class CardTransaction
    {
        [JsonProperty("isSeidFromDataSource")]
        public int IsSeidFromDataSource { get; set; }

        [JsonProperty("isSeidMod")]
        public int IsSeidMod { get; set; }

        [JsonProperty("srcElementId")]
        public string SrcElementId { get; set; }

        [JsonProperty("transactionTypeId")]
        public int TransactionTypeId { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("localizedTransactionType")]
        public string LocalizedTransactionType { get; set; }

        [JsonProperty("transactionStatusId")]
        public int TransactionStatusId { get; set; }

        [JsonProperty("transactionStatus")]
        public string TransactionStatus { get; set; }

        [JsonProperty("localizedTransactionStatus")]
        public string LocalizedTransactionStatus { get; set; }

        [JsonProperty("transactionBaseTypeId")]
        public int TransactionBaseTypeId { get; set; }

        [JsonProperty("transactionBaseType")]
        public string TransactionBaseType { get; set; }

        [JsonProperty("localizedTransactionBaseType")]
        public string LocalizedTransactionBaseType { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("cardTransactionId")]
        public int CardTransactionId { get; set; }

        [JsonProperty("cardAccountId")]
        public int CardAccountId { get; set; }

        [JsonProperty("isDeleted")]
        public int IsDeleted { get; set; }

        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }

        [JsonProperty("hasDetails")]
        public int HasDetails { get; set; }

        [JsonProperty("transactionCategoryId")]
        public string TransactionCategoryId { get; set; }

        [JsonProperty("classUpdationSource")]
        public string ClassUpdationSource { get; set; }

        [JsonProperty("lastCategorised")]
        public string LastCategorised { get; set; }

        [JsonProperty("transDate")]
        public TransDate TransDate { get; set; }

        [JsonProperty("categorisationSourceId")]
        public string CategorisationSourceId { get; set; }

        [JsonProperty("plainTextDescription")]
        public string PlainTextDescription { get; set; }

        [JsonProperty("postDate")]
        public PostDate PostDate { get; set; }

        [JsonProperty("prevTransactionCategoryId")]
        public int PrevTransactionCategoryId { get; set; }

        [JsonProperty("descriptionViewPref")]
        public int DescriptionViewPref { get; set; }

        [JsonProperty("transAmount")]
        public TransAmount TransAmount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("categorizationKeyword")]
        public string CategorizationKeyword { get; set; }

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