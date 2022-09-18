using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.DataContext;
using Entities.Concreate;
using Business.Abstract;

namespace PortalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactBusiness;

        public ContactsController(IContactService contactBusiness)
        {
            _contactBusiness = contactBusiness;
        }

        [HttpGet("GetContacts")]
        public List<Contact> GetContact()
        {
            return _contactBusiness.GetList().Data;
        }

        [HttpPost("SaveContacts")]
        public bool SaveContact([FromBody] Contact contact)
        {
            return _contactBusiness.Add(contact).IsSuccess;
        }

        [HttpDelete("DeleteContacts")]
        public bool DeleteContact([FromBody] Contact contact)
        {
            return _contactBusiness.Delete(contact).IsSuccess;
        }

        [HttpPut("UpdateContacts")]
        public bool UpdateContact([FromBody] Contact contact)
        {
            return _contactBusiness.Update(contact).IsSuccess;
        }
    }
}
