using System.Data.SqlClient;
using FutPool.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SpaServices.Webpack;

namespace FutPool
{
    public class Startup
    {
        private string _devDbConnectionString = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _devDbConnectionString = Configuration["ConnectionStrings:FutPoolConnection"];
            //services.AddDbContext<FutPoolContext>(opt => opt.UseInMemoryDatabase("Teams"));
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<FutPoolContext>(opt => opt.UseNpgsql(_devDbConnectionString));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true,
                    //HotModuleReplacementEndpoint = "/__webpack_hmr"
                });
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();

            // app.UseMvc(routes =>
            // {
            //     routes.MapRoute(
            //         name: "default",
            //         template: "{controller=Home}/{action=Index}/{id?}");

            //     routes.MapSpaFallbackRoute(
            //         name: "spa-fallback",
            //         defaults: new { controller = "Home", action = "Index" });
            // });
        }
    }
}
