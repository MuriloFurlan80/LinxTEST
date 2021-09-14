using SO.Domain.Entity;
using SO.Domain.Repository;
using SO.Domain.Services;
using SO.ViewModel;
using System.Threading.Tasks;

namespace SO.Business
{
    public class ExpenseTotalService : IExpenseTotalService
    {
        private readonly IExpenseTotalRepository _repository;

        public ExpenseTotalService(IExpenseTotalRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExpenseTotalViewModel> GetByStoreAsync(string storeId)
        {
            var result = await _repository.GetByStoreAsync(storeId);
            if (result != null)
                return new(result.Id, result.Value, result.StoreId, result.Store?.Name);

            return null;
        }
        public async Task<ExpenseTotalViewModel> Update(ExpenseTotalViewModel input)
        {
            var result = await _repository.UpdateAsync(new ExpenseTotal(input.Id, input.Value), input.Id);
            if (result != null)
                return new(result.Id, result.Value, result.StoreId, result.Store?.Name);
            return null;
        }
    }
}
