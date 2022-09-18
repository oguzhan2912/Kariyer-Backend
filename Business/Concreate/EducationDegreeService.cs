using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class EducationDegreeService : IEducationDegreeService
    {
        private IEducationDegreeDao _educationDegreeDao;

        public EducationDegreeService(IEducationDegreeDao educationDegreeDao)
        {
            _educationDegreeDao = educationDegreeDao;
        }

        public IResult Add(EducationDegree educationDegree)
        {
            _educationDegreeDao.Add(educationDegree);//Entity Frameworku kullanarak Add metodu ile kolay bir şekilde save işlemi yaptık.
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(EducationDegree educationDegree)
        {
            _educationDegreeDao.Delete(educationDegree);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<EducationDegree>> GetList()
        {
            return new SuccessDataResult<List<EducationDegree>>(_educationDegreeDao.GetAll().ToList());
        }

        public IResult Update(EducationDegree educationDegree)
        {
            _educationDegreeDao.Update(educationDegree);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
