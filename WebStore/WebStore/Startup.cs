using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebStore
{
    public class Startup
    {
        // + для доступа к json-файлу конфигурации 
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // - для доступа к json-файлу конфигурации 

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); // иницализация MVC для приложения
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // для доступа у файлам на сервере

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"); // по сути это задание основного пути к запрос т.е. www.loclhost:3550 == www.localhost:3550/home/index
            });

            //app.UseMvcWithDefaultRoute(); // эта команда должна равносильна тому что написано выше (так нагляднее)
            
        }
    }
}
