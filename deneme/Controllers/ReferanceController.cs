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
    public class ReferanceController : ControllerBase
    {
        private readonly IReferanceBusinessEngine _referanceBusiness;
        public ReferanceController(IReferanceBusinessEngine referanceBusiness)
        {
            _referanceBusiness = referanceBusiness;
        }

        [HttpGet("GetReferances")]
        public List<ReferanceDto> GetItems()
        {
            return _referanceBusiness.GetItems().Data;
        }

    }
}
