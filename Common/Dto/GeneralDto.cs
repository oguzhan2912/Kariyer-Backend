using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class GeneralDto
    {

        public int GeneralId { get; set; }        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Graduation { get; set; }
        public string Gender { get; set; }
        public string IdentityType { get; set; }
        public int IdentityNum { get; set; }
        public bool DriverLicense { get; set; }
        public string DriverLicenseType { get; set; }
        public string MartialStatus { get; set; }
        public string Nation { get; set; }

        /*Personal*/
        public DateTime DateOfBirth { get; set; }
        public string BornedCity { get; set; }
        public string BornedCountry { get; set; }
    }
}
