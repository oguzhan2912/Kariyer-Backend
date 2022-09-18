using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class ContactService : IContactService
    {
        private IContactDao _contactDao;

        public ContactService(IContactDao contactDao)
        {
            _contactDao = contactDao;
        }
        public IResult Add(Contact contact)
        {
           _contactDao.Add(contact);//Entity Frameworku kullanarak Add metodu ile kolay bir şekilde save işlemi yaptık.
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(Contact contact)
        {
           _contactDao.Delete(contact);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<Contact>> GetList()
        {
            return new SuccessDataResult<List<Contact>>(_contactDao.GetAll().ToList());//bütün listeyi döndürme
        }

        public IResult Update(Contact contact)
        {
           _contactDao.Update(contact);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}
