using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Contracts;
using Entities.Concreate;

namespace deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserService _applicationUserEngine;

        public ApplicationUserController(IApplicationUserService applicationUserEngine)
        {
            _applicationUserEngine = applicationUserEngine;
        }


        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Register")]
        public async Task<Object> PostApplicationUser(ApplicationUser model)
        {
            var data = _applicationUserEngine.CreateApplicationUser(model);
            var result = data.Result.Data;
            return Ok(result);
        }
 



    }
}
