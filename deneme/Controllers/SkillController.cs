﻿using Business.Contracts;
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
    public class SkillController : ControllerBase
    {
        private readonly ISkillBusinessEngine _skillBusiness;
        public SkillController(ISkillBusinessEngine skillBusiness)
        {
            _skillBusiness = skillBusiness;
        }

        [HttpGet("GetSkills")]
        public List<SkillDto> GetItems()
        {
            return _skillBusiness.GetItems().Data;
        }
    }
}