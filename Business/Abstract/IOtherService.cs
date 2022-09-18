using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOtherService
    {
        IResult Add(Other other);
        IResult Delete(Other other);
        IResult Update(Other other);
        IDataResult<List<Other>> GetList();
    }
}
