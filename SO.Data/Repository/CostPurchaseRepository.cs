using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;

namespace SO.Data.Repository
{
    public class CostPurchaseRepository : Repository<CostPurchase>, ICostPurchaseRepository
    {
        public CostPurchaseRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
        }
    }
}
