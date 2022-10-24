using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class ReferanceService : IReferanceService
    {
        private IReferanceDao _referanceDao;
        public ReferanceService(IReferanceDao referanceDao)
        {
            _referanceDao = referanceDao;
        }

        public IResult Add(Referance referance)
        {
            _referanceDao.Add(referance);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(Referance referance)
        {
            referance.IsDeleted = 1;
            _referanceDao.Update(referance);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<Referance>> GetList()
        {
            return new SuccessDataResult<List<Referance>>(_referanceDao.GetAll(w => w.IsDeleted == 0).ToList());
        }

        public IResult Update(Referance referance)
        {
            _referanceDao.Update(referance);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
