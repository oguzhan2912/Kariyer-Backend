using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class GeneralService : IGeneralService
    {
        private IGeneralDao _generalDao;
        public GeneralService(IGeneralDao generalDao)
        {
            _generalDao = generalDao;
        }
        public IResult Add(General general)
        {
            _generalDao.Add(general);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(General general)
        {
            _generalDao.Delete(general);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<General>> GetList()
        {
            return new SuccessDataResult<List<General>>(_generalDao.GetAll().ToList());
        }

        public IResult Update(General general)
        {
            _generalDao.Update(general);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
