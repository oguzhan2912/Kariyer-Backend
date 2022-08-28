using Common.Dto;
using Common.ResultConstant;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contracts
{
    public interface IEducationPostDegreeBusinessEngine
    {
        Result<List<EducationPostDegreeDto>> GetItems();
    }
}
