using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SO.Domain.Repository
{
    public interface IRepository<T> : IRepositoryBase where T : class
    {
        Task<T> SaveAsync(T entity);
        Task<T> UpdateAsync(T entity, string key);
        Task<int> DeleteAsync(T entity);
        Task<T> GetAsync(Guid id);
        Task<ICollection<T>> GetAsync();
        IQueryable<T> Queryable { get; }
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<int> CountAsync();
        Task<T> FirstAsync();
    }
}
