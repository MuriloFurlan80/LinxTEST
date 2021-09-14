using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;

namespace SO.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
        }
    }
}
