using Business.Contracts;
using Common.DataContracts;
using Common.Dto;
using Common.ResultConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Implementaion
{
     public class SkillBusinessEngine : ISkillBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public SkillBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<SkillDto>> GetItems()
        {
            List<SkillDto> skills = new List<SkillDto>();
            var data = _uow.skills.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    skills.Add(new SkillDto()
                    {
                        SkillId = item.SkillId,
                        SkillName = item.SkillName             
                        
                    });

                }
                return new Result<List<SkillDto>>(true, ResultConstant.RecordFound, skills);

            }
            return new Result<List<SkillDto>>(false, ResultConstant.RecordNotCreated, skills);
        }
    }
}
