using System;
using System.Threading.Tasks;
using Common.Dto;
using Data.DbModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Data.DataContext;
using Business.Contracts;

namespace deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserBusinessEngine _applicationUserEngine;

        public ApplicationUserController(IApplicationUserBusinessEngine applicationUserEngine)
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
        public async Task<Object> PostApplicationUser(ApplicationUserDto model)
        {
            var data = _applicationUserEngine.CreateApplicationUser(model);
            var result = data.Result.Data;
            return Ok(result);
        }
 



    }
}
