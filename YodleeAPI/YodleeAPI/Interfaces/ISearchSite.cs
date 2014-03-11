﻿using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface ISearchSite
    {
        Task<ServiceResult> Login(SearchSiteInfo param);
    }
}