using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace deneme.Controllers
{
    [Route("api/Skills")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly IService<Skill> _skillBusiness;
        public SkillController(IService<Skill> skillBusiness)
        {
            _skillBusiness = skillBusiness;
        }

        [HttpGet("GetSkills")]
        public List<Skill> GetItems()
        {
            return _skillBusiness.GetItems().Data;
        }
    }
}
