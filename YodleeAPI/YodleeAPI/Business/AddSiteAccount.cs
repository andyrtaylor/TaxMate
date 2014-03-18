using System;
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Business;
using MYOB.TaxMate.YodleeAPI.Interfaces;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.business
{
    public sealed class AddSiteAccount : BaseBusiness, IAddSiteAccount
    {
        private const String Url = "jsonsdk/SiteAccountManagement/addSiteAccount?";

        public AddSiteAccount() : base(Url){}

        public Task<ServiceResult> Add(SiteAccountInfo param)
        {
            EndPoint += param.Parameters;

            return Execute();
        }
    }
}