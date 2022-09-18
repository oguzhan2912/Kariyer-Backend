using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
     public class SkillService : ISkillService
    {
        private ISkillDao _skillDao;
        public SkillService(ISkillDao skillDao)
        {
            _skillDao = skillDao;
        }

        public IResult Add(Skill skill)
        {
            _skillDao.Add(skill);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(Skill skill)
        {
            _skillDao.Delete(skill);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<Skill>> GetList()
        {
            return new SuccessDataResult<List<Skill>>(_skillDao.GetAll().ToList());
        }

        public IResult Update(Skill skill)
        {
            _skillDao.Update(skill);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
