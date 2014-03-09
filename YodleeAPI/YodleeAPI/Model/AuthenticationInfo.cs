using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "AuthenticationRequest")]
    public class AuthenticationInfo
    {
        [DataMember(Name = "Login", IsRequired = true)]
        public string CobrandLogin { get; set; }

        [DataMember(Name = "Password", IsRequired = true)]
        public string CobrandPassword { get; set; }
    }
}