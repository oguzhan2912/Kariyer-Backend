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
        public List<PostWork> GetPostWork()
        {
            return _postWorkBusiness.GetList().Data;
        }

        [HttpPost("SavePostWorks")]
        public bool SavePostWork([FromBody] PostWork postWork)
        {
            return _postWorkBusiness.Add(postWork).IsSuccess;
        }

        [HttpPost("DeletePostWorks")]
        public bool DeletePostWork([FromBody] PostWork postWork)
        {
            return _postWorkBusiness.Delete(postWork).IsSuccess;
        }

        [HttpPut("UpdatePostWorks")]
        public bool UpdatePostWork([FromBody] PostWork postWork)
        {
            return _postWorkBusiness.Update(postWork).IsSuccess;
        }
    }
}
