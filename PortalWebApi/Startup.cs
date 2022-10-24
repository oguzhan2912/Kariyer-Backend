
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Entities.Concreate;

using Business.Concreate;
using DataAccess.DataContext;
using Autofac;
using Business.AutoFac;

namespace deneme
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
            services.AddCors();
            services.AddControllers();                                 
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           app.UseCors(builder => builder
                 .AllowAnyHeader()
                 .AllowAnyMethod()
                 .SetIsOriginAllowed((host) => true)
                 .AllowCredentials()
             );
            app.UseSwagger();
            app.UseSwaggerUI(c => {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PortalWebApi v1");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseCors(options => options.WithOrigins("http://localhost:4200/")
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .AllowCredentials()
                             );

            app.UseHttpsRedirection();        
           
            app.UseAuthorization();

            app.UseAuthentication();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                ;
            });     
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {           
            builder.RegisterModule(new BusinessAutoFacModule());                      
        }


    }
}
