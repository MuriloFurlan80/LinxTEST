using Microsoft.EntityFrameworkCore;
using SO.Data.ORM;
using SO.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SO.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SaleOnlineDbContext _dbContext;

        public Repository(SaleOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SaleOnlineDbContext Context => _dbContext;

        public IQueryable<T> Queryable => _dbContext.Set<T>();

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await _dbContext.Set<T>().Where(match).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await _dbContext.Set<T>().Where(match).ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _dbContext.Set<T>().CountAsync();
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<ICollection<T>> GetAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<T> SaveAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity, string key)
        {
            if (entity is null)
                return null;

            T exist = _dbContext.Set<T>().Find(key);
            if (exist != null)
            {
                _dbContext.Entry(exist).CurrentValues.SetValues(entity);
                _dbContext.Entry(exist).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            return exist;
        }

        public async Task<T> FirstAsync()
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync();
        }
    }
}
