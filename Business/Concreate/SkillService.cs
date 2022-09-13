using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
     public class SkillService : IService<Skill>
    {
       
        public Result<List<Skill>> GetItems()
        {
            List<Skill> skills = new List<Skill>();
            var data = skills;//_uow.skills.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    skills.Add(new Skill()
                    {
                        Id = item.Id,
                        SkillName = item.SkillName             
                        
                    });

                }
                return new Result<List<Skill>>(true, ResultConstant.RecordFound, skills);

            }
            return new Result<List<Skill>>(false, ResultConstant.RecordNotCreated, skills);
        }
    }
}
