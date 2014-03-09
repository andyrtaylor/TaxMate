using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "getSiteLoginFormRequest")]
    public class GetSiteLoginFormInfo
    {
        [DataMember(Name = "cobSessionToken", IsRequired = true)]
        public string CobSessionToken { get; set; }

        [DataMember(Name = "userSessionToken", IsRequired = true)]
        public string UserSessionToken { get; set; }

        [DataMember(Name = "siteId", IsRequired = true)]
        public string SiteId { get; set; }
    }
}