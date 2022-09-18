using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace deneme.Controllers
{
    [Route("api/EducationPostDegrees")]
    [ApiController]
    public class EducationPostDegreeController : ControllerBase
    {
        private readonly IEducationPostDegreeService _educationPostDegreeBusiness;

        public EducationPostDegreeController(IEducationPostDegreeService educationPostDegreeBusiness)
        {
            _educationPostDegreeBusiness = educationPostDegreeBusiness;
        }

        [HttpGet("GetEducationPostDegrees")]
        public List<EducationPostDegree> GetEducationPostDegree()
        {
            return _educationPostDegreeBusiness.GetList().Data;
        }

        [HttpPost("SaveEducationPostDegrees")]
        public bool SaveEducationPostDegree([FromBody] EducationPostDegree educationPostDegree)
        {
            return _educationPostDegreeBusiness.Add(educationPostDegree).IsSuccess;
        }

        [HttpDelete("DeleteEducationPostDegrees")]
        public bool DeleteEducationPostDegree([FromBody] EducationPostDegree educationPostDegree)
        {
            return _educationPostDegreeBusiness.Delete(educationPostDegree).IsSuccess;
        }

        [HttpPut("UpdateEducationPostDegrees")]
        public bool UpdateEducationPostDegree([FromBody] EducationPostDegree educationPostDegree)
        {
            return _educationPostDegreeBusiness.Update(educationPostDegree).IsSuccess;
        }
    }
}
