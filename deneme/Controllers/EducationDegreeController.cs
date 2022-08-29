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
    public class EducationDegreeController : ControllerBase
    {
        private readonly IEducationDegreeBusinessEngine _educationDegreeBusiness;
        public EducationDegreeController(IEducationDegreeBusinessEngine educationDegreeBusiness)
        {
            _educationDegreeBusiness = educationDegreeBusiness;
        }

        [HttpGet("GetEducationDegrees")]
        public List<EducationDegreeDto> GetItems()
        {
            return _educationDegreeBusiness.GetItems().Data;
        }
    }
}
