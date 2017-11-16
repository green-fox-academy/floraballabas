using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GotCharacterApp.Repositories;
using GotCharacterApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace GotCharacterApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GotCharacterContext>(options => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = GotCharactermaster; Integrated Security = True; Connect Timeout = 30;"));
            services.AddScoped<GotCharacterRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
