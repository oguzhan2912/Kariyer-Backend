using Common.ResultConstant;
using Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contracts
{
    public interface IGeneralBusinessEngine
    {
        Result<List<GeneralDto>> GetItems();
    }
}
