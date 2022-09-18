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
        public List<Skill> GetSkill()
        {
            return _skillBusiness.GetList().Data;
        }

        [HttpPost("SaveSkills")]
        public bool SaveSkill([FromBody] Skill skill)
        {
            return _skillBusiness.Add(skill).IsSuccess;
        }

        [HttpDelete("DeleteSkills")]
        public bool DeleteSkill([FromBody] Skill skill)
        {
            return _skillBusiness.Delete(skill).IsSuccess;
        }

        [HttpPut("UpdateSkills")]
        public bool UpdateSkill([FromBody] Skill skill)
        {
            return _skillBusiness.Update(skill).IsSuccess;
        }


    }
}
