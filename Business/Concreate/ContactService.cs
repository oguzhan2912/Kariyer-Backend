using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class ContactService: IContactService
    {
        //private readonly IUnitOfWork _uow;

      /*  public ContactBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }*/

        public Result<List<Contact>> GetItems()
        {
            List<Contact> contacts = new List<Contact>();
            var data = contacts;
            if (data != null)
            {
                foreach (var item in data)
                {
                    contacts.Add(new Contact()
                    {
                        Id = item.Id,
                        Country = item.Country,
                        City = item.City,
                        District = item.District,
                        Address = item.Address,
                        WorkPhone = item.WorkPhone,
                        HomePhone = item.HomePhone,
                        CellPhone = item.CellPhone,
                        CellPhone2 = item.CellPhone2,
                        MailAdress = item.MailAdress,
                        Goal = item.Goal,
                        Position = item.Position,
                        SalaryExp = item.SalaryExp,
                        General = item.General
                    });

                }
                return new Result<List<Contact>>(true, ResultConstant.RecordFound, contacts);

            }
            return new Result<List<Contact>>(false, ResultConstant.RecordNotCreated, contacts);
        }

       
    }
}
