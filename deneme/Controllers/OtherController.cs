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
    public class OtherController : ControllerBase
    {
        private readonly IOtherBusinessEngine _otherBusiness;
        public OtherController(IOtherBusinessEngine otherBusiness)
        {
            _otherBusiness = otherBusiness;
        }

        [HttpGet("GetOthers")]
        public List<OtherDto> GetItems()
        {
            return _otherBusiness.GetItems().Data;
        }
    }
}
