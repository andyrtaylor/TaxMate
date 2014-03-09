using System;
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Business;
using MYOB.TaxMate.YodleeAPI.Interfaces;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.business
{
    public sealed class CobrandUserLogin : BaseBusiness, ICobrandUserLogin
    {
        private const String Url = "authenticate/login";

        public CobrandUserLogin() : base(Url){}

        public Task<ServiceResult> Login(UserAuthenticationInfo param)
        {
            Parameters.Add("login", param.CobrandLogin);
            Parameters.Add("password", param.CobrandPassword);
            Parameters.Add("cobSessionToken", param.CobSessionToken);

            return Execute();
        }
    }
}