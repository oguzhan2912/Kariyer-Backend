using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class PostWorkService : IPostWorkService
    {
        private IPostWorkDao _postWorkDao;
        public PostWorkService(IPostWorkDao postWorkDao)
        {
            _postWorkDao = postWorkDao;
        }
        public IResult Add(PostWork postWork)
        {
            _postWorkDao.Add(postWork);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(PostWork postWork)
        {
            _postWorkDao.Delete(postWork);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<PostWork>> GetList()
        {
            return new SuccessDataResult<List<PostWork>>(_postWorkDao.GetAll().ToList());
        }

        public IResult Update(PostWork postWork)
        {
            _postWorkDao.Update(postWork);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
