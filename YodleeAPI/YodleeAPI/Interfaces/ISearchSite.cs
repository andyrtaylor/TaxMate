using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;
using MYOB.TaxMate.YodleeAPI.model.DTO;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface ISearchSite
    {
        Task<ServiceResult> Login(SearchSiteInfo param);
    }
}