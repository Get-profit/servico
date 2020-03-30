using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoAPI.Application;
using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Context;
using ProjetoAPI.Domain.Interfaces.Repositories;
using ProjetoAPI.Domain.Interfaces.Services;
using ProjetoAPI.Domain.Services;
using ProjetoAPI.Infrastructure.Data.Repositories;

namespace API
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
            services.AddDbContext<AcessoriosContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("Acessorios"));
            });

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient<IClientesRepository, ClientesRepository>();
            services.AddTransient<IUsuariosRepository, UsuariosRepository>();
            services.AddTransient<IOrdemServicoRepository, OrdemServicoRepository>();

            services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<IUsuariosService, UsuariosService>();
            services.AddTransient<IOrdemServicoService, OrdemServicoService>();

            services.AddTransient(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddTransient<IClientesAppService, ClientesAppService>();
            services.AddTransient<IUsuariosAppService, UsuariosAppService>();
            services.AddTransient<IOrdemServicoAppService, OrdemServicoAppService>();

            services.AddMvc(options => {
                options.EnableEndpointRouting = false;
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
