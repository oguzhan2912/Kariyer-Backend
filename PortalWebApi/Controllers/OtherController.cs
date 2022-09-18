using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        private readonly IOtherService _otherBusiness;

        public OtherController(IOtherService otherBusiness)
        {
            _otherBusiness = otherBusiness;
        }

        [HttpGet("GetOthers")]
        public List<Other> GetOther()
        {
            return _otherBusiness.GetList().Data;
        }

        [HttpPost("SaveOthers")]
        public bool SaveOther([FromBody] Other other)
        {
            return _otherBusiness.Add(other).IsSuccess;
        }

        [HttpDelete("DeleteOthers")]
        public bool DeleteOther([FromBody] Other other)
        {
            return _otherBusiness.Delete(other).IsSuccess;
        }

        [HttpPut("UpdateOthers")]
        public bool UpdateOther([FromBody] Other other)
        {
            return _otherBusiness.Update(other).IsSuccess;
        }
    }
}
