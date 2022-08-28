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
    public class EducationController : ControllerBase
    {
        private readonly IEducationBusinessEngine _educationBusiness;
        public EducationController(IEducationBusinessEngine educationBusiness)
        {
            _educationBusiness = educationBusiness;
        }

        [HttpGet("GetEducations")]
        public List<EducationDto> GetItems()
        {
            return _educationBusiness.GetItems().Data;
        }
    }
}
