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
    public class EducationPostDegreeController : ControllerBase
    {

        private readonly IEducationPostDegreeBusinessEngine _educationPostDegreeBusiness;
        public EducationPostDegreeController(IEducationPostDegreeBusinessEngine educationPostDegreeBusiness)
        {
            _educationPostDegreeBusiness = educationPostDegreeBusiness;
        }

        [HttpGet("GetEducationPostDegrees")]
        public List<EducationPostDegreeDto> GetItems()
        {
            return _educationPostDegreeBusiness.GetItems().Data;
        }
    }
}
