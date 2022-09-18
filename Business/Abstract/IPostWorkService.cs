using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPostWorkService
    {
        IResult Add(PostWork postWork);
        IResult Delete(PostWork postWork);
        IResult Update(PostWork postWork);
        IDataResult<List<PostWork>> GetList();
    }
}
