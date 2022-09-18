using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
namespace Business.Abstract
{
    public interface IGeneralService
    {
        IResult Add(General general);
        IResult Delete(General general);
        IResult Update(General general);
        IDataResult<List<General>> GetList();
    }
}
