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
    public class GeneralController : ControllerBase
    {

        private readonly IGeneralBusinessEngine _generalBusiness;
        public GeneralController(IGeneralBusinessEngine generalBusiness)
        {
            _generalBusiness = generalBusiness;
        }

        [HttpGet("GetGenerals")]
        public List<GeneralDto> GetItems()
        {
            return _generalBusiness.GetItems().Data;
        }
    }
}
