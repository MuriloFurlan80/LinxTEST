using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;

namespace SO.Data.Repository
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
        }
    }
}
