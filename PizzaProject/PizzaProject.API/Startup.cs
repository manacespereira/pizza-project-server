using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaProject.Data;
using PizzaProject.Data.Repositories;
using PizzaProject.Domain.CommandHandlers;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.QueryHandlers;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PizzaProjectContext>();

            ConfigureDI(services);

            services.AddMvc()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureDI(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region Repositories
            services.AddScoped<ICustomizationRepository, CustomizationRepository>();
            services.AddScoped<IFlavorRepository, FlavorRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<IPizzaSizeRepository, PizzaSizeRepository>();
            #endregion

            #region Commands
            services.AddScoped<OrderCommandHandler>();
            #endregion

            #region Queries
            services.AddScoped<CustomizationQueryHandler>();
            services.AddScoped<FlavorQueryHandler>();
            services.AddScoped<OrderQueryHandler>();
            services.AddScoped<PizzaSizeQueryHandler>();
            #endregion
        }
    }
}
