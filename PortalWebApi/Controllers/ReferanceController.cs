using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace deneme.Controllers
{
    [Route("api/Referances")]
    [ApiController]
    public class ReferanceController : ControllerBase
    {
        private readonly IReferanceService _referanceBusiness;

        public ReferanceController(IReferanceService referanceBusiness)
        {
            _referanceBusiness = referanceBusiness;
        }

        [HttpGet("GetReferances")]
        public List<Referance> GetReferance()
        {
            return _referanceBusiness.GetList().Data;
        }

        [HttpPost("SaveReferances")]
        public bool SaveReferance([FromBody] Referance referance)
        {
            return _referanceBusiness.Add(referance).IsSuccess;
        }

        [HttpPost("DeleteReferances")]
        public bool DeleteReferance([FromBody] Referance referance)
        {
            return _referanceBusiness.Delete(referance).IsSuccess;
        }

        [HttpPut("UpdateReferances")]
        public bool UpdateReferance([FromBody] Referance referance)
        {
            return _referanceBusiness.Update(referance).IsSuccess;
        }
    }
}
