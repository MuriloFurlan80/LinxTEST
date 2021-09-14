using SO.ViewModel;
using System.Threading.Tasks;

namespace SO.Domain.Services
{
    public interface IExpenseTotalService : IService
    {
        Task<ExpenseTotalViewModel> GetByStoreAsync(string storeId);
        Task<ExpenseTotalViewModel> Update(ExpenseTotalViewModel input);
    }
}
