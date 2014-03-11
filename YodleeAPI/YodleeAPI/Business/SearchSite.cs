using System;
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Business;
using MYOB.TaxMate.YodleeAPI.Interfaces;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.business
{
    public sealed class SearchSite : BaseBusiness, ISearchSite
    {
        private const String Url = "jsonsdk/SiteTraversal/searchSite";

        public SearchSite() : base(Url){}

        public Task<ServiceResult> Login(SearchSiteInfo param)
        {
            Parameters.Add("cobSessionToken", param.CobSessionToken);
            Parameters.Add("userSessionToken", param.UserSessionToken);
            Parameters.Add("siteSearchString", param.SiteSearchString);

            return Execute();
        }
    }
}