using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace deneme.Controllers
{
    [Route("api/Educations")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationService _educationBusiness;

        public EducationController(IEducationService educationBusiness)
        {
            _educationBusiness = educationBusiness;
        }

        [HttpGet("GetEducations")]
        public List<Education> GetEducation()
        {
            return _educationBusiness.GetList().Data;
        }

        [HttpPost("SaveEducations")]
        public bool SaveEducation([FromBody] Education education)
        {
            return _educationBusiness.Add(education).IsSuccess;
        }

        [HttpDelete("DeleteEducations")]
        public bool DeleteEducation([FromBody] Education education)
        {
            return _educationBusiness.Delete(education).IsSuccess;
        }

        [HttpPut("UpdateEducations")]
        public bool UpdateEducation([FromBody] Education education)
        {
            return _educationBusiness.Update(education).IsSuccess;
        }
    }
}
