using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class Contact : BaseCard
    {
               
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int WorkPhone { get; set; }
        public int HomePhone { get; set; }
        public int CellPhone { get; set; }
        public int CellPhone2 { get; set; }
        public string MailAdress { get; set; }

        /*Expectations*/

        public string Goal { get; set; }
        public string Position { get; set; }
        public string SalaryExp { get; set; }
        public string General { get; set; }

        /*Connections*/
        
        


    }
}
