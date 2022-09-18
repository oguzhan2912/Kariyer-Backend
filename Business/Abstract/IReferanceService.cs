using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
namespace Business.Abstract
{
   public interface IReferanceService
    {
        IResult Add(Referance referance);
        IResult Delete(Referance referance);
        IResult Update(Referance referance);
        IDataResult<List<Referance>> GetList();
    }
}
