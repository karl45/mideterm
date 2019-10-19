using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetfirst.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetfirst
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<PlayerContext>(options =>
            {
                options.UseSqlite("Filename=players.db");
            });
            services.AddDbContext<TeamContext>(options =>
            {
                options.UseSqlite("Filename=teams.db");
            });
            services.AddMvc();
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseMvc(routes =>
            {
                    /*routes.MapRoute(
                    name:"default",
                    template: "{controller=Calculator}/{action}/{number:int}",
                    defaults:new { action="PlusTen"}
                    );*/
               /* routes.MapRoute(
                    name:"ShowSentence",
                    template: "say/{*message}",
                    defaults:new { controller="Message",action="ShowMessage"}
                    ) ;*/
                routes.MapRoute(
                    name: "Control",
                    template: "{controller=Team}/{action=Index}/{id?}");
            });

            app.UseStaticFiles();
            
        }
    }
}
