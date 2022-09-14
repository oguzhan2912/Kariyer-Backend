
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
            
            services.AddScoped< LanguageService>();
            services.AddScoped< ContactService>();
            services.AddScoped< GeneralService>(); 
            services.AddScoped< EducationService>();
            services.AddScoped< EducationDegreeService>();
            services.AddScoped< EducationPostDegreeService>();
            services.AddScoped< ReferanceService>();
            services.AddScoped< SkillService>();
            services.AddScoped< OtherService>();
            services.AddScoped< PostWorkService>();                       
            /*services
                .AddIdentity<ApplicationUser, IdentityRole>()
                .AddDefaultTokenProviders().
                AddEntityFrameworkStores<PortalDbContext>();*/

            services.AddScoped<ApplicationUserService>();

            services.AddDbContext<PortalDbContext>(
            options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

           

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
        public void ConfigureContainer(ContainerBuilder builder)
        {
            #region WAY-1 (Autofac Module)

            // Add modules registrations.

            builder.RegisterModule(new MyAutofacModule());
            //builder.RegisterModule(new MyAutofacModule2());
            //builder.RegisterModule(new MyAutofacModule3());

            #endregion

            #region WAY-2 (Direct Registration)

            // Add services registrations.

            builder.RegisterType<MyService>().As<IService>();

            #endregion
        }


    }
}
