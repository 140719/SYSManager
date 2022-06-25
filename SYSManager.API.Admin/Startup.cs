using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SYSManager.Application.Services;
using System.Runtime.InteropServices;

namespace SYSManager.API.Admin
{
    public class Startup
    {
        public void BeforeConfigureService(IServiceCollection services)
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            BeforeConfigureService(services);
            services.AddApiVersioning();
            services.AddScoped<UserService>();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc();
        }
    }

    
}

