﻿using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
namespace Business.Abstract
{
    public interface ISkillService
    {
        Result<List<Skill>> GetItems();

    }
}
