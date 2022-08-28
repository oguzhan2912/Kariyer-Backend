using Business.Contracts;
using Common.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Controllers
{   
    [Route("api/Languages")]
    [ApiController]
    
    public class LanguageController : ControllerBase
    {

        private readonly ILanguageBusinessEngine _languageBusiness;
        public LanguageController(ILanguageBusinessEngine languageBusiness)
        {
            _languageBusiness = languageBusiness;
        }
        
        [HttpGet("GetLanguages")]
        public List<LanguageDto> GetItems()
        {
            return _languageBusiness.GetItems().Data;
        }
    }
}
