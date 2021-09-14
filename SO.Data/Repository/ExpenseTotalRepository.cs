using Microsoft.EntityFrameworkCore;
using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace SO.Data.Repository
{
    public class ExpenseTotalRepository : Repository<ExpenseTotal>, IExpenseTotalRepository
    {
        public ExpenseTotalRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ExpenseTotal> GetByStoreAsync(string storeId)
        {
            return await Queryable
                .Include(x => x.Store)
                .FirstOrDefaultAsync(x => x.StoreId == storeId);
        }
    }
}
