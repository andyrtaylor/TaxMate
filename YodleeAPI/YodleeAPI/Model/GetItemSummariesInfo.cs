using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "getItemSummariesRequest")]
    public class GetItemSummariesInfo
    {
        [DataMember(Name = "cobSessionToken", IsRequired = true)]
        public string CobSessionToken { get; set; }

        [DataMember(Name = "userSessionToken", IsRequired = true)]
        public string UserSessionToken { get; set; }
    }
}