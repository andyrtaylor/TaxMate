using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;

namespace MYOB.TaxMate.YodleeAPI.Interfaces
{
    public interface IGetItemSummaries
    {
        Task<ServiceResult> GetItems(GetItemSummariesInfo param);
    }
}