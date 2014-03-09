using System;
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Business;
using MYOB.TaxMate.YodleeAPI.Interfaces;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.business
{
    public sealed class GetItemSummaries : BaseBusiness, IGetItemSummaries
    {
        private const String Url = "jsonsdk/DataService/getItemSummaries";

        public GetItemSummaries() : base(Url){}

        public Task<ServiceResult> Login(GetItemSummariesInfo param)
        {
            Parameters.Add("cobSessionToken", param.CobSessionToken);
            Parameters.Add("userSessionToken", param.UserSessionToken);

            return Execute();
        }
    }
}