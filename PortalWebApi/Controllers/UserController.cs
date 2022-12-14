using Business.Abstract;
using Entities.Concreate;
using Entities.Concreate.UserLogin;
using Entities.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PortalWebApi.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Authenticate")]        
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }


        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            bool isUserExist;
            isUserExist = _userService.IsUserExist(user);

            if (isUserExist)
                return BadRequest("Kullanıcı adı sistemde kayıtlıdır.");

            var users = _userService.Insert(user);
            return Ok(users);
        }

    }
}
