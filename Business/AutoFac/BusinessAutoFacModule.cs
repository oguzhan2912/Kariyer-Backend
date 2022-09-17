using Autofac;
using Business.Concreate;
using Business.Abstract;


namespace Business.AutoFac
{
    public class BusinessAutoFacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
           // builder.RegisterType<MyService>().As<IService>();

            // Other Lifetime
            // Transient
           // builder.RegisterType<MyService>().As<IService>()
               // .InstancePerDependency();

            // Scoped
            builder.RegisterType<ApplicationUserService>().As<IApplicationUserService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ContactService>().As<IContactService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<EducationDegreeService>().As<IEducationDegreeService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<EducationPostDegreeService>().As<IEducationPostDegreeService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<EducationService>().As<IEducationService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<GeneralService>().As<IGeneralService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<LanguageService>().As<ILanguageService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<OtherService>().As<IOtherService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<PostWorkService>().As<IPostWorkService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<ReferanceService>().As<IReferanceService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<SkillService>().As<ISkillService>()
               .InstancePerLifetimeScope();
            
            //DAOLARI EKLE!!


            //  builder.RegisterType<MyService>().As<IService>()
            //   .InstancePerRequest();

            // Singleton
            //  builder.RegisterType<MyService>().As<IService>()
            //  .SingleInstance();


        }
    }
}
