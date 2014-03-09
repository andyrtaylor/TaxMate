using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "AuthenticationUserLoginRequest")]
    public class UserAuthenticationInfo : AuthenticationInfo
    {
        [DataMember(Name = "cobSessionToken", IsRequired = true)]
        public string CobSessionToken { get; set; }
    }
}