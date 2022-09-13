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

        private readonly IService<EducationPostDegree> _educationPostDegreeBusiness;
        public EducationPostDegreeController(IService<EducationPostDegree> educationPostDegreeBusiness)
        {
            _educationPostDegreeBusiness = educationPostDegreeBusiness;
        }

        [HttpGet("GetEducationPostDegrees")]
        public List<EducationPostDegree> GetItems()
        {
            return _educationPostDegreeBusiness.GetItems().Data;
        }
    }
}
