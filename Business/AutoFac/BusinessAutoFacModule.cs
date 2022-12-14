using Autofac;
using Business.Concreate;
using Business.Abstract;
using DataAccess.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.UserLogin;
using DataAccess.Abstract.UserLogin;

namespace Business.AutoFac
{
    public class BusinessAutoFacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {        
          
           // builder.RegisterType<ApplicationUserService>().As<IApplicationUserService>();
            builder.RegisterType<ContactService>().As<IContactService>();
           
            builder.RegisterType<EducationService>().As<IEducationService>();
            builder.RegisterType<GeneralService>().As<IGeneralService>();
            builder.RegisterType<LanguageService>().As<ILanguageService>();
            builder.RegisterType<OtherService>().As<IOtherService>();
            builder.RegisterType<PostWorkService>().As<IPostWorkService>();
            builder.RegisterType<ReferanceService>().As<IReferanceService>();
            builder.RegisterType<SkillService>().As<ISkillService>();
                     

           // builder.RegisterType<ApplicationUserDao>().As<IApplicationUserDao>();
            builder.RegisterType<ContactDao>().As<IContactDao>();

            builder.RegisterType<EducationDao>().As<IEducationDao>();
            builder.RegisterType<GeneralDao>().As<IGeneralDao>();
            builder.RegisterType<LanguageDao>().As<ILanguageDao>();
            builder.RegisterType<OtherDao>().As<IOtherDao>();
            builder.RegisterType<PostWorkDao>().As<IPostWorkDao>();
            builder.RegisterType<ReferanceDao>().As<IReferanceDao>();
            builder.RegisterType<SkillDao>().As<ISkillDao>();
            
        }
    }
}
