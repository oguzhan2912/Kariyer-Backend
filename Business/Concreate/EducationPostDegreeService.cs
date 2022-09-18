using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class EducationPostDegreeService : IEducationPostDegreeService
    {
        private IEducationPostDegreeDao _educationPostDegreeDao;
        public EducationPostDegreeService(IEducationPostDegreeDao educationPostDegreeDao)
        {
            _educationPostDegreeDao = educationPostDegreeDao;
        }
        public IResult Add(EducationPostDegree educationPostDegree)
        {
            _educationPostDegreeDao.Add(educationPostDegree);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(EducationPostDegree educationPostDegree)
        {
            _educationPostDegreeDao.Delete(educationPostDegree);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<EducationPostDegree>> GetList()
        {
            return new SuccessDataResult<List<EducationPostDegree>>(_educationPostDegreeDao.GetAll().ToList());
        }

        public IResult Update(EducationPostDegree educationPostDegree)
        {
            _educationPostDegreeDao.Update(educationPostDegree);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
