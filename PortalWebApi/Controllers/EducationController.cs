using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IService<Education> _educationBusiness;
        public EducationController(IService<Education> educationBusiness)
        {
            _educationBusiness = educationBusiness;
        }

        [HttpGet("GetEducations")]
        public List<Education> GetItems()
        {
            return _educationBusiness.GetItems().Data;
        }
    }
}
