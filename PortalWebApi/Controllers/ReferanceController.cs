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
        private readonly IService<Referance> _referanceBusiness;
        public ReferanceController(IService<Referance> referanceBusiness)
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
