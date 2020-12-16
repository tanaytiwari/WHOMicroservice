using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WHOMicroservice
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

           
            services.AddControllers();
            services.AddCors(options => options.AddPolicy("Cors",
       builder =>
       {
           builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
       }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseRouting();

            app.UseAuthorization();
            //app.UseCors(builder =>
            //{
            //    builder.WithOrigins("http://localhost:4200/");
            //});



            //app.UseCors(builder =>
            //{
            //    builder.AllowAnyHeader();
            //    builder.AllowAnyMethod();
            //    builder.AllowAnyOrigin(); // For anyone access.
            //                              //corsBuilder.WithOrigins("http://localhost:56573"); // for a specific url.
            //});
            app.UseCors("Cors");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           
        }
    }
}
