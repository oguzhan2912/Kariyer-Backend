using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace deneme.Controllers
{   
    [Route("api/Languages")]
    [ApiController]
    
    public class LanguageController : ControllerBase
    {

        private readonly ILanguageService _languageBusiness;
      
        public LanguageController(ILanguageService languageBusiness)
        {
            _languageBusiness = languageBusiness;
           
        }
        [HttpGet("GetLanguages")]
        public List<Language> GetItems()
        {
            return _languageBusiness.GetItems().Data;
        }

        /*
        [HttpPost("SaveLanguages")]
        public bool SaveLanguage([FromBody]Language language)
        {
            return _languageBusiness.SaveLanguage(language).IsSuccess;
        }*/
               
    }
}
