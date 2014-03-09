using System;
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Business;
using MYOB.TaxMate.YodleeAPI.Interfaces;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.business
{
    public sealed class GetSiteLoginForm : BaseBusiness, IGetSiteLoginForm
    {
        private const String Url = "jsonsdk/SiteAccountManagement/getSiteLoginForm";

        public GetSiteLoginForm() : base(Url){}

        public Task<ServiceResult> Login(GetSiteLoginFormInfo param)
        {
            Parameters.Add("cobSessionToken", param.CobSessionToken);
            Parameters.Add("userSessionToken", param.UserSessionToken);
            Parameters.Add("siteId", param.SiteId);

            return Execute();
        }
    }
}