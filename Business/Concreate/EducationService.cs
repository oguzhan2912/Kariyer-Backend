using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;


namespace Business.Concreate
{
    public class EducationService:IEducationService
    {
        private IEducationDao _educationDao;
        public EducationService(IEducationDao educationDao)
        {
            _educationDao = educationDao;
        }

        public IResult Add(Education education)
        {
            _educationDao.Add(education);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(Education education)
        {
            _educationDao.Delete(education);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<Education>> GetList()
        {
            return new SuccessDataResult<List<Education>>(_educationDao.GetAll().ToList());
        }

        public IDataResult<List<Education>> GetByGradeLevel(int gradeLevel)
        {
            return new SuccessDataResult<List<Education>>(_educationDao.GetAll(w => w.GradeLevel == gradeLevel).ToList());//o propertye ait bütün değerleri döndürme
        }

        public IResult Update(Education education)
        {
            _educationDao.Update(education);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }

    }
}
