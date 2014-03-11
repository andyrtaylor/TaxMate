using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class Account
    {
        [JsonProperty("isSeidFromDataSource")]
        public int IsSeidFromDataSource { get; set; }

        [JsonProperty("isSeidMod")]
        public int IsSeidMod { get; set; }

        [JsonProperty("acctTypeId")]
        public int AcctTypeId { get; set; }

        [JsonProperty("acctType")]
        public string AcctType { get; set; }

        [JsonProperty("localizedAcctType")]
        public string LocalizedAcctType { get; set; }

        [JsonProperty("srcElementId")]
        public string SrcElementId { get; set; }

        [JsonProperty("cardAccountId")]
        public int CardAccountId { get; set; }

        [JsonProperty("isDeleted")]
        public int IsDeleted { get; set; }

        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }

        [JsonProperty("hasDetails")]
        public int HasDetails { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("cashApr")]
        public double CashApr { get; set; }

        [JsonProperty("tranListToDate")]
        public TranListToDate TranListToDate { get; set; }

        [JsonProperty("tranListFromDate")]
        public TranListFromDate TranListFromDate { get; set; }

        [JsonProperty("runningBalance")]
        public RunningBalance RunningBalance { get; set; }

        [JsonProperty("pendingCharges")]
        public PendingCharges PendingCharges { get; set; }

        [JsonProperty("lastPayment")]
        public LastPayment LastPayment { get; set; }

        [JsonProperty("availableCredit")]
        public AvailableCredit AvailableCredit { get; set; }

        [JsonProperty("availableCash")]
        public AvailableCash AvailableCash { get; set; }

        [JsonProperty("totalCreditLine")]
        public TotalCreditLine TotalCreditLine { get; set; }

        [JsonProperty("totalCashLimit")]
        public TotalCashLimit TotalCashLimit { get; set; }

        [JsonProperty("asofDate")]
        public AsofDate AsofDate { get; set; }

        [JsonProperty("dueDate")]
        public DueDate DueDate { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("lastPaymentDate")]
        public LastPaymentDate LastPaymentDate { get; set; }

        [JsonProperty("derivedAutopayEnrollmentStatusId")]
        public int DerivedAutopayEnrollmentStatusId { get; set; }

        [JsonProperty("derivedAutopayEnrollmentStatus")]
        public string DerivedAutopayEnrollmentStatus { get; set; }

        [JsonProperty("localizedDerivedAutopayEnrollmentStatus")]
        public string LocalizedDerivedAutopayEnrollmentStatus { get; set; }

        [JsonProperty("stmtListToDate")]
        public StmtListToDate StmtListToDate { get; set; }

        [JsonProperty("stmtListFromDate")]
        public StmtListFromDate StmtListFromDate { get; set; }

        [JsonProperty("apr")]
        public double Apr { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("userAutopayEnrollmentStatus")]
        public string UserAutopayEnrollmentStatus { get; set; }

        [JsonProperty("localizedUserAutopayEnrollmentStatus")]
        public string LocalizedUserAutopayEnrollmentStatus { get; set; }

        [JsonProperty("derivedAutopayEnrollmentStatusLastUpdated")]
        public int DerivedAutopayEnrollmentStatusLastUpdated { get; set; }

        [JsonProperty("autopayEnrollmentStatusId")]
        public int AutopayEnrollmentStatusId { get; set; }

        [JsonProperty("autopayEnrollmentStatus")]
        public string AutopayEnrollmentStatus { get; set; }

        [JsonProperty("localizedAutopayEnrollmentStatus")]
        public string LocalizedAutopayEnrollmentStatus { get; set; }

        [JsonProperty("cardTransactions")]
        public CardTransaction[] CardTransactions { get; set; }

        [JsonProperty("cardStatements")]
        public CardStatement[] CardStatements { get; set; }

        [JsonProperty("isPaperlessStmtOn")]
        public int IsPaperlessStmtOn { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("itemDataTableId")]
        public int ItemDataTableId { get; set; }

        [JsonProperty("itemAccountStatusId")]
        public int ItemAccountStatusId { get; set; }

        [JsonProperty("includeInNetworth")]
        public int IncludeInNetworth { get; set; }

        [JsonProperty("isLinkedItemAccount")]
        public bool IsLinkedItemAccount { get; set; }

        [JsonProperty("isUpdatePastTransaction")]
        public bool IsUpdatePastTransaction { get; set; }

        [JsonProperty("isUpdateTxCategory")]
        public bool IsUpdateTxCategory { get; set; }

        [JsonProperty("createOpeningTxn")]
        public bool CreateOpeningTxn { get; set; }

        [JsonProperty("cacheItemId")]
        public int CacheItemId { get; set; }

        [JsonProperty("isItemAccountDeleted")]
        public int IsItemAccountDeleted { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("accountDisplayName")]
        public AccountDisplayName AccountDisplayName { get; set; }

        [JsonProperty("itemAccountId")]
        public int ItemAccountId { get; set; }

        [JsonProperty("baseTagDataId")]
        public string BaseTagDataId { get; set; }

        [JsonProperty("refreshTime")]
        public int RefreshTime { get; set; }

        [JsonProperty("bankAccountId")]
        public int? BankAccountId { get; set; }

        [JsonProperty("accountHolder")]
        public string AccountHolder { get; set; }

        [JsonProperty("availableBalance")]
        public AvailableBalance AvailableBalance { get; set; }

        [JsonProperty("currentBalance")]
        public CurrentBalance CurrentBalance { get; set; }

        [JsonProperty("maturityDate")]
        public MaturityDate MaturityDate { get; set; }

        [JsonProperty("asOfDate")]
        public AsOfDate2 AsOfDate { get; set; }
    }
}