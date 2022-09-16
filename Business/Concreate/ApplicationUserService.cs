using System;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concreate;
using Microsoft.AspNetCore.Identity;

namespace Business.Concreate
{
    public class ApplicationUserService:IApplicationUserService
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        /*
        public async Task<Result <object>> CreateApplicationUser(ApplicationUser model)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                Name = model.Name,                
                Lastname = model.Lastname
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                if (result.Errors.Count()>0)
                {
                    return new Result<object>(false, ResultConstant.RecordNotCreated);
                }

                return new Result<object>(true, ResultConstant.RecordCreated,result);
            }
            catch (Exception)
            {

                return new Result<object>(true, ResultConstant.RecordNotCreated);
            }
        }
        */
        Task<Result<object>> IApplicationUserService.CreateApplicationUser(ApplicationUser model)
        {
            throw new NotImplementedException();
        }
    }

}
