using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class GeneralInfo
    {
        [Key]
        public int GeneralId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Graduation { get; set; }
        public string Gender { get; set; }
        public string  IdentityType { get; set; }
        public int IdentityNum { get; set; }
        public bool DriverLicense { get; set; }
        public string DriverLicenseType { get; set; }
        public string MartialStatus { get; set; }
        public string Nation { get; set; }        

        /*Personal*/
        public DateTime DateOfBirth { get; set; }
        public string BornedCity { get; set; }
        public string BornedCountry { get; set; }


        /*Connections*/

        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }
        public int? BaseId { get; set; }
        public virtual BaseCard Base { get; set; }


    }
}
