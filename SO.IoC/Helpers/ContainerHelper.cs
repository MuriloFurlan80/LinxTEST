using Microsoft.Extensions.DependencyInjection;
using SO.Business;
using SO.Data.Repository;
using SO.Domain.Repository;
using SO.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SO.IoC.Helpers
{
    public class ContainerHelper
    {
        public static void Register(IServiceCollection service) =>
        Register(service, typeof(IStoreRepository), typeof(StoreRepository), typeof(IStoreService),
            typeof(StoreService));


        public static void Register(IServiceCollection service, Type @interface, Type @class)
        {
            var interfaces = Assembly.GetAssembly(@interface)?.GetTypes()
                .Where(x => (bool)(x?.IsInterface) && x.GetInterface(@interface.Name) != null);

            if (interfaces == null) return;

            RegisterTypes(service, @class, interfaces);
        }

        public static void Register(IServiceCollection service, Type repositoryInterface, Type repositoryImplmentation,
            Type serviceInterface, Type serviceImplementation)
        {
            RegisterRepository(service, repositoryInterface, repositoryImplmentation);
            RegisterService(service, serviceInterface, serviceImplementation);
        }

        public static void RegisterService(IServiceCollection service, Type @interface, Type @class)
        {
            var type = typeof(IService);

            var serviceAbstract = Assembly.GetAssembly(@interface)?.GetTypes()
                .Where(x => x.GetInterfaces().Contains(type) || x.IsAssignableFrom(type) && x.IsInterface);

            RegisterServiceTypes(service, @class, serviceAbstract);
        }

        public static void RegisterRepository(IServiceCollection service, Type @interface, Type @class)
        {
            var typeGeneric = typeof(IRepository<>);
            service.AddTransient(typeGeneric, typeof(Repository<>));

            var abstractTypes = Assembly.GetAssembly(@interface)?.GetTypes()
                .Where(x => (bool)(x?.IsInterface) && x.GetInterface(typeGeneric.Name) != null);

            RegisterTypes(service, @class, abstractTypes);
        }

        private static void RegisterTypes(IServiceCollection service, Type @class, IEnumerable<Type> interfaces)
        {
            foreach (var abstractType in interfaces)
            {
                var concrete = Assembly.GetAssembly(@class)?.GetTypes()
                    .Where(x => (bool)(x?.IsClass) && x.GetInterface(abstractType.Name) != null)
                    ?.FirstOrDefault();

                if (concrete is not null)
                    service.AddTransient(abstractType, concrete);
            }
        }

        private static void RegisterServiceTypes(IServiceCollection service, Type @class, IEnumerable<Type> interfaces)
        {
            foreach (var abstractType in interfaces)
            {
                var types = Assembly.GetAssembly(@class)?.GetTypes()
                    .Where(x => (bool)(x?.IsClass) && x.GetInterface(abstractType.Name) != null)
                    ?.ToList();

                types?.ForEach((concrete) => service.AddTransient(abstractType, concrete));
            }
        }
    }
}
