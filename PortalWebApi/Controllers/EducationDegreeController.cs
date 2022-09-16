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
        public List<EducationDegree> GetItems()
        {
            return _educationDegreeBusiness.GetItems().Data;
        }
    }
}
