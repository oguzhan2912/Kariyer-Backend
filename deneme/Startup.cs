using Common.DataContracts;
using Data.DataContext;
using Data.Implementaion;
using deneme.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using Business.Contracts;
using Business.Implementaion;
using Data.DbModel;
using Microsoft.IdentityModel.Tokens;

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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ILanguageBusinessEngine, LanguageBusinessEngine>();
            services.AddScoped<IContactBusinessEngine, ContactBusinessEngine>();
            services.AddScoped<IGeneralBusinessEngine,GeneralBusinessEngine>(); 
            services.AddScoped<IEducationBusinessEngine, EducationBusinessEngine>();
            services.AddScoped<IEducationPostDegreeBusinessEngine, EducationPostDegreeBusinessEngine>();

            services.AddDbContext<denemeDbContext>(
            options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddDefaultTokenProviders().
                AddEntityFrameworkStores<denemeDbContext>();

            services.AddScoped<IApplicationUserBusinessEngine, ApplicationUserBusinessEngine>();
            

           

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
      


    }
}
