using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace deneme.Controllers
{
    [Route("api/EducationDegrees")]
    [ApiController]
    public class EducationDegreeController : ControllerBase
    {
        private readonly IEducationDegreeService _educationDegreeBusiness;

        public EducationDegreeController(IEducationDegreeService educationDegreeBusiness)
        {
            _educationDegreeBusiness = educationDegreeBusiness;
        }

        [HttpGet("GetEducationDegrees")]
        public List<EducationDegree> GetEducationDegree()
        {
            return _educationDegreeBusiness.GetList().Data;
        }

        [HttpPost("SaveEducationDegrees")]
        public bool SaveEducationDegree([FromBody] EducationDegree educationDegree)
        {
            return _educationDegreeBusiness.Add(educationDegree).IsSuccess;
        }

        [HttpDelete("DeleteEducationDegrees")]
        public bool DeleteEducationDegree([FromBody] EducationDegree educationDegree)
        {
            return _educationDegreeBusiness.Delete(educationDegree).IsSuccess;
        }

        [HttpPut("UpdateEducationDegrees")]
        public bool UpdateEducationDegree([FromBody] EducationDegree educationDegree)
        {
            return _educationDegreeBusiness.Update(educationDegree).IsSuccess;
        }
    }
}
