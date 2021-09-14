using SO.Data.ORM;
using SO.Domain.Entity;
using SO.Domain.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace SO.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly SaleOnlineDbContext _dbContext;
        public ProductRepository(SaleOnlineDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductsByStore(string id) =>
            //var query = from product in _dbContext.Set<Product>()
            //            join photo in _dbContext.Set<Photo>()
            //                on product.Id equals photo.ProductId
            //            join cost in _dbContext.Set<CostPurchase>()
            //                on product.Id equals cost.ProductId
            //            where product.StoreId == id
            //            select new { product, photo, cost };

            //var products = 
            //    query.Select(x => new Product(x.product.Id, x.product.Name, x.product.Price, x.product.Description, x.product.Quantity, id, x.photo));

            await Queryable
                .Include(x => x.Photo)
                .Where(x => x.StoreId == id && x.CostPurchase.Id != null)
                .ToListAsync();

    }
}
