using RM.BaseArchitecture.Api.Proxy;
using RM.BaseArchitecture.Api.Proxy.Interfaces;
using RM.BaseArchitecture.Application.Interfaces;
using RM.BaseArchitecture.Application.Services;
using RM.BaseArchitecture.Domain.Interfaces.Repository;
using RM.BaseArchitecture.Infrastructure.Data;
using SimpleInjector;

namespace RM.BaseArchitecture.Infrastructure.CrossCutting.Bootstrapper
{
    public static class SimpleInjectorMapping
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
        }

        public static void RegisterProxies(Container container)
        {
            container.Register<IClienteProxy, ClienteProxy>(Lifestyle.Scoped);
        }
    }
}
