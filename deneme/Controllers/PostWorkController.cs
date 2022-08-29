using Business.Contracts;
using Common.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostWorkController : ControllerBase
    {
        private readonly IPostWorkBusinessEngine _postWorkBusiness;
        public PostWorkController(IPostWorkBusinessEngine postWorkBusiness)
        {
            _postWorkBusiness = postWorkBusiness;
        }

        [HttpGet("GetPostWorks")]
        public List<PostWorkDto> GetItems()
        {
            return _postWorkBusiness.GetItems().Data;
        }
    }
}
