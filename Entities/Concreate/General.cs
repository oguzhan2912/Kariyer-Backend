using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class General : BaseCard
    {
        
        public string Name { get; set; }        
        public string LastName { get; set; }
        public string Graduation { get; set; }
        public string Gender { get; set; }
        public string IdentityType { get; set; }
        public int IdentityNum { get; set; }        
        public string DriverLicenseType { get; set; }
        public string MartialStatus { get; set; }
        public string Nation { get; set; }        

        /*Personal*/
        public DateTime DateOfBirth { get; set; }
        public string BornedCity { get; set; }
        public string BornedCountry { get; set; }


        /*Connections*/

        public int? CVId { get; set; }
        public virtual CV CVInfo { get; set; }
        

    }
}
