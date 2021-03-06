﻿using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface ICobrandLogin
    {
        Task<ServiceResult> Login(AuthenticationInfo param);
    }
}