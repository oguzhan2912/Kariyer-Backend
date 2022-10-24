using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class OtherService : IOtherService
    {
        private IOtherDao _otherDao;
        public OtherService(IOtherDao otherDao)
        {
            _otherDao = otherDao;
        }
        public IResult Add(Other other)
        {
            _otherDao.Add(other);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(Other other)
        {
            _otherDao.Delete(other);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<Other>> GetList()
        {
            return new SuccessDataResult<List<Other>>(_otherDao.GetAll(w => w.IsDeleted == 0).ToList());
        }

        public IResult Update(Other other)
        {
            _otherDao.Update(other);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
