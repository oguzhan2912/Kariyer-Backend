using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace deneme.Controllers
{
    [Route("api/PostWorks")]
    [ApiController]
    public class PostWorkController : ControllerBase
    {
        private readonly IPostWorkService _postWorkBusiness;
        public PostWorkController(IPostWorkService postWorkBusiness)
        {
            _postWorkBusiness = postWorkBusiness;
        }

        [HttpGet("GetPostWorks")]
        public List<PostWork> GetItems()
        {
            return _postWorkBusiness.GetItems().Data;
        }
    }
}
