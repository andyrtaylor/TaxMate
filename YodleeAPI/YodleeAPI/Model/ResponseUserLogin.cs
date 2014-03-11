
using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class ResponseUserLogin
    {
        [JsonProperty("userContext")]
        public UserContext UserContext { get; set; }

        [JsonProperty("lastLoginTime")]
        public int LastLoginTime { get; set; }

        [JsonProperty("loginCount")]
        public int LoginCount { get; set; }

        [JsonProperty("passwordRecovered")]
        public bool PasswordRecovered { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("loginName")]
        public string LoginName { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("userType")]
        public UserType UserType { get; set; }

        [JsonProperty("isConfirmed")]
        public bool IsConfirmed { get; set; }
    }
}
