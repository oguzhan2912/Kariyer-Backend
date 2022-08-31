using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class EducationDegreeInfo
    {

        /*Degree*/
        [Key]
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public DateTime DegreeGraduationDate { get; set; }
        public string DegreeDepartment { get; set; }
        public string DegreeCountry { get; set; }
        public string DegreeState { get; set; }
        public decimal DegreeGPA { get; set; }
        public string DegreeNewSchool { get; set; }
        public string DegreeNewDepartment { get; set; }
        
        /*Connections*/
        public int? EducationId { get; set; }
        public virtual EducationInfo Education { get; set; }
        public int? BaseId { get; set; }
        public virtual BaseCard Base { get; set; }
    }
}
