using Newtonsoft.Json;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    public class AsofDate
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("localFormat")]
        public string LocalFormat { get; set; }
    }

    public class AsOfDate2
    {
    }
}