using System.Runtime.Serialization;

namespace MYOB.TaxMate.YodleeAPI.Model
{
    [DataContract(Name = "Response")]
    public class ServiceResult
    {
        public ServiceResult(string body)
        {
            Populate(body, true);
        }

        public ServiceResult(string body, bool valid)
        {
            Populate(body, valid);
        }

        [DataMember(Name = "Body", IsRequired = true)]
        public string Result { get; set; }

        [DataMember(Name = "isValid", IsRequired = false, EmitDefaultValue = false)]
        public bool IsValid { get; set; }

        private void Populate(string body, bool valid)
        {
            Result = body;
            IsValid = valid;
        }
    }
}