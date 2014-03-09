using System;
using MYOB.TaxMate.YodleeAPI.Business;
using MYOB.TaxMate.YodleeAPI.Interfaces;
using MYOB.TaxMate.YodleeAPI.Model;
using System.Threading.Tasks;

namespace MYOB.TaxMate.YodleeAPI.business
{
    public sealed class CobrandLogin : BaseBusiness, ICobrandLogin
    {
        private const String Url = "authenticate/coblogin";

        public CobrandLogin() : base(Url){}

        public async Task<ServiceResult> Login(AuthenticationInfo param)
        {
            Parameters.Add("cobrandLogin", param.CobrandLogin);
            Parameters.Add("cobrandPassword", param.CobrandPassword);

            return await Execute();
        }
    }
}