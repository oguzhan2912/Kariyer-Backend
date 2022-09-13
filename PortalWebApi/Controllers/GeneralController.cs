using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {

        private readonly IService<General> _generalBusiness;
        public GeneralController(IService<General> generalBusiness)
        {
            _generalBusiness = generalBusiness;
        }

        [HttpGet("GetGenerals")]
        public List<General> GetItems()
        {
            return _generalBusiness.GetItems().Data;
        }
    }
}
