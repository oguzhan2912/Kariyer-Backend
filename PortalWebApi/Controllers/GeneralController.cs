using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace deneme.Controllers
{
    [Route("api/Generals")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly IGeneralService _generalBusiness;

        public GeneralController(IGeneralService generalBusiness)
        {
            _generalBusiness = generalBusiness;
        }

        [HttpGet("GetGenerals")]
        public List<General> GetGeneral()
        {
            return _generalBusiness.GetList().Data;
        }

        [HttpPost("SaveGenerals")]
        public bool SaveGeneral([FromBody] General general)
        {
            return _generalBusiness.Add(general).IsSuccess;
        }

        [HttpDelete("DeleteGenerals")]
        public bool DeleteGeneral([FromBody] General general)
        {
            return _generalBusiness.Delete(general).IsSuccess;
        }

        [HttpPut("UpdateGenerals")]
        public bool UpdateGeneral([FromBody] General general)
        {
            return _generalBusiness.Update(general).IsSuccess;
        }

    }
}
