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
        private readonly IService<Other> _otherBusiness;
        public OtherController(IService<Other> otherBusiness)
        {
            _otherBusiness = otherBusiness;
        }

        [HttpGet("GetOthers")]
        public List<Other> GetItems()
        {
            return _otherBusiness.GetItems().Data;
        }
    }
}
