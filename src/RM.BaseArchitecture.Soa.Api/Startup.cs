using RM.BaseArchitecture.Infrastructure.CrossCutting.Bootstrapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;

namespace RM.BaseArchitecture.Soa.Api
{
    public class Startup
    {
        public static Container Container;

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            AdicionarInjecaoControllers(services);
        }

        private static Container CriarContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            SimpleInjectorMapping.RegisterServices(container);
            return container;
        }

        private static void AdicionarInjecaoControllers(IServiceCollection services)
        {
            Container = CriarContainer();
            Container.Register<IHttpContextAccessor, HttpContextAccessor>(Lifestyle.Singleton);
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(Container));
            services.UseSimpleInjectorAspNetRequestScoping(Container);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}