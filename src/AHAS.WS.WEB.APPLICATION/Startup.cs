using AHAS.WS.INFRA.DATA.Context;
using AHAS.WS.INFRA.DATA.Repository;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.WS.LOGIC.SERVICE.Services;
using AHAS.WS.LOGIC.SERVICE.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;

namespace AHAS.WS.WEB.APPLICATION
{
    public class Startup
    {
        private Container container = new Container();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Registrar Validator
            services.AddMvc(opt =>
            {
                opt.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fvc => { });

            services.AddTransient<IValidator<ContaContabil>, ContaContabilValidator>();

            // Registrar services
            container.Register<IContaContabilService, ContaContabilService>(Lifestyle.Scoped);
            container.Register<IContaContabilRepository, ContaContabilRepository>(Lifestyle.Scoped);

            container.Register(typeof(IBaseService<>), typeof(BaseService<>));
            container.Register(typeof(IRepository<>), typeof(BaseRepository<>));

            container.Register<DataBaseSQLContext>(Lifestyle.Scoped);

            // Registrar DI
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(container));

            services.UseSimpleInjectorAspNetRequestScoping(container);
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

            container.RegisterMvcControllers(app);
            container.Verify();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
