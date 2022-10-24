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
        public List<Language> GetLanguage()
        {
            return _languageBusiness.GetList().Data;
        }
        [HttpGet("GetLanguageById")]
        public Language GetById(int languageId)
        {
            return _languageBusiness.GetById(languageId).Data;
        }

        [HttpPost("SaveLanguages")]
        public bool SaveLanguage([FromBody] Language language)
        {
            return _languageBusiness.Add(language).IsSuccess;
        }        

        [HttpPut("UpdateLanguages")]
        public bool UpdateLanguage([FromBody] Language language)
        {
            return _languageBusiness.Update(language).IsSuccess;
        }

        [HttpPost("DeleteLanguages")]
        public bool DeleteLanguage([FromBody] Language language)
        {
            return _languageBusiness.Delete(language).IsSuccess;
        }
    }
}
