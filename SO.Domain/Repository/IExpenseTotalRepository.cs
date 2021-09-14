using SO.Domain.Entity;
using SO.ViewModel;
using System.Threading.Tasks;

namespace SO.Domain.Repository
{
    public interface IExpenseTotalRepository : IRepository<ExpenseTotal>
    {
        Task<ExpenseTotal> GetByStoreAsync(string storeId);
    }
}
