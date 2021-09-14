using SO.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SO.Domain.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByStore(string id);
    }
}
