using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "addSiteAccountRequest")]
    public class SiteAccountInfo
    {
        [DataMember(Name = "parameters", IsRequired = true)]
        public string Parameters { get; set; }
    }
}