using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface IAddSiteAccount
    {
        Task<ServiceResult> Add(SiteAccountInfo param);
    }
}