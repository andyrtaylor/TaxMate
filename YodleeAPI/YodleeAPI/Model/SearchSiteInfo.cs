using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "SearchSiteRequest")]
    public class SearchSiteInfo
    {
        [DataMember(Name = "cobSessionToken", IsRequired = true)]
        public string CobSessionToken { get; set; }

        [DataMember(Name = "userSessionToken", IsRequired = true)]
        public string UserSessionToken { get; set; }

        [DataMember(Name = "siteSearchString", IsRequired = true)]
        public string SiteSearchString { get; set; }
    }
}