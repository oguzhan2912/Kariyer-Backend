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

        private readonly IService<Language> _languageBusiness;
      
        public LanguageController(IService<Language> languageBusiness)
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
