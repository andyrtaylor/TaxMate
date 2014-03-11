using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class UserType
    {
        [JsonProperty("userTypeId")]
        public int UserTypeId { get; set; }

        [JsonProperty("userTypeName")]
        public string UserTypeName { get; set; }
    }
}