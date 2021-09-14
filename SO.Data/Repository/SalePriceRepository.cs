using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;

namespace SO.Data.Repository
{
    public class SalePriceRepository : Repository<SalePrice>, ISalePriceRepository
    {
        public SalePriceRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
        }
    }
}
