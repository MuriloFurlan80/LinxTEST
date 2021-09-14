using Microsoft.EntityFrameworkCore;
using SO.Domain.Entity;
using System.Reflection;

namespace SO.Data.ORM
{
    public class SaleOnlineDbContext : DbContext
    {
        public DbSet<Store> DBStore { get; set; }
        public DbSet<CostPurchase> DBCostPurchase{ get; set; }
        public DbSet<ExpenseTotal> DBExpenseTotal{ get; set; }
        public DbSet<Product> DBProduct{ get; set; }
        public DbSet<SalePrice> DBSalePrice{ get; set; }
        public DbSet<User> DBUser{ get; set; }

        public SaleOnlineDbContext(DbContextOptions<SaleOnlineDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
