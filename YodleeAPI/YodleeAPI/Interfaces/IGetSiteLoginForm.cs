using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface IGetSiteLoginForm
    {
        Task<ServiceResult> Login(GetSiteLoginFormInfo param);
    }
}