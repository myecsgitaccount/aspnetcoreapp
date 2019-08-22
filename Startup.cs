using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing; 

namespace aspnetcoreapp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHello, Hello>(); 
            services.AddMvc(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHello hello, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();    
            //app.UseMvcWithDefaultRoute();   
            app.UseMvc(ConfigureRoutes); 
                
            
            app.Map("/test", testPipeline); 
            // app.Run(async (context) =>
            // {
            //     //await context.Response.WriteAsync("Hello World!");
            //     // await context.Response.WriteAsync(hello.SayHello()); 
            //     logger.LogInformation("Response Served"); 
            //     await context.Response.WriteAsync(hello.SayHello()); 
            // });

            
        }

        private static void ConfigureRoutes(IRouteBuilder routes)
        {
            routes.MapRoute("default", "{controller=Home}/{action=index}/{id?}");
        }
        private static void testPipeline(IApplicationBuilder app)
        {
            app.Run(async context => {
                await context.Response.WriteAsync("Hello from test mapping"); 
            });  
        }
    }
}
