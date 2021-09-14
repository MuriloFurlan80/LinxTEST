using Microsoft.Extensions.DependencyInjection;
using SO.IoC.Helpers;
using System;

namespace SO.IoC.Extensions
{
    public static class ContainerExtension
    {

        public static void Register(this IServiceCollection service)
        {
            ContainerHelper.Register(service);
        }

        public static void Register(this IServiceCollection service, Type @interface, Type @class)
        {
            ContainerHelper.Register(service, @interface, @class);
        }

        public static void Register(this IServiceCollection service, Type repositoryInterface, Type repositoryImplmentation,
            Type serviceInterface, Type serviceImplementation)
        {
            ContainerHelper.Register(service, repositoryInterface, repositoryImplmentation, serviceInterface, serviceImplementation);
        }
    }
}
