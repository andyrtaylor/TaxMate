using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class UserActionRequiredType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}