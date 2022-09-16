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
        public List<Referance> GetItems()
        {
            return _referanceBusiness.GetItems().Data;
        }

    }
}
