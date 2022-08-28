using Business.Contracts;
using Common.DataContracts;
using Common.Dto;
using Common.ResultConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Implementaion
{
    public class ContactBusinessEngine: IContactBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public ContactBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<ContactDto>> GetItems()
        {
            List<ContactDto> contacts = new List<ContactDto>();
            var data = _uow.contacts.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    contacts.Add(new ContactDto()
                    {
                        ContactId = item.ContactId,
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
                return new Result<List<ContactDto>>(true, ResultConstant.RecordFound, contacts);

            }
            return new Result<List<ContactDto>>(false, ResultConstant.RecordNotCreated, contacts);
        }
    }
}
