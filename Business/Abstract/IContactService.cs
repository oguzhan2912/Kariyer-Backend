using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;


namespace Business.Abstract
{
   public interface IContactService
    {
        IResult Add(Contact contact);
        IResult Delete(Contact contact);
        IResult Update(Contact contact);
        IDataResult<List<Contact>> GetList();
    }
}
