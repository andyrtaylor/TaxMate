using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface IAddSiteAccount
    {
        Task<ServiceResult> Login(SiteAccountInfo param);
    }
}