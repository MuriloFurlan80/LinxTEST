using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SO.Business;
using SO.Data.ORM;
using SO.Data.Repository;
using SO.Domain.Repository;
using SO.Domain.Services;
using SO.IoC.Extensions;
using System.Collections.Generic;
using System.Threading;

namespace SO.IoC
{
    public class ApplicationManager
    {
        public static void Init(IServiceCollection services, IConfiguration Configuration)
        {
            var threads = new List<Thread>
            {
                new Thread(() => {
                    var connection = Configuration["Connection:SqlLiteConnectionString"];
                    services.AddDbContext<SaleOnlineDbContext>(options => options.UseSqlite(connection,
                        x => x.MigrationsAssembly("SO.Data")));
                }),
                
                new Thread(() => {
                    services.Register(typeof(IRepository<>), typeof(Repository<>), typeof(IService), typeof(Service));
                })
            };

            foreach (var thread in threads)
                thread.Start();

            foreach (var thread in threads)
                thread.Join();
        }
    }
}

