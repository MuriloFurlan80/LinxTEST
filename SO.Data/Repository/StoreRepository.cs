using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;

namespace SO.Data.Repository
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
        }
    }
}
