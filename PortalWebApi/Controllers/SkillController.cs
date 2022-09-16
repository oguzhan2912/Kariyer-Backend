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
        private readonly ISkillService _skillBusiness;
        public SkillController(ISkillService skillBusiness)
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
