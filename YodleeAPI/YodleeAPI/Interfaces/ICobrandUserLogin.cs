using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface ICobrandUserLogin
    {
        Task<ServiceResult> Login(UserAuthenticationInfo param);
    }
}