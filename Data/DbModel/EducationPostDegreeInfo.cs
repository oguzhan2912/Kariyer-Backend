using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class EducationPostDegreeInfo
    {
        /*Postgraduation*/
        [Key]
        public int PostgraduationId { get; set; }
        public string PostgraduationName { get; set; }
        public DateTime PostgraduationGraduationDate { get; set; }
        public string PostgraduationDepartment { get; set; }
        public string PostgraduationCountry { get; set; }
        public string PostgraduationState { get; set; }
        public decimal PostgraduationGPA { get; set; }
        public string PostgraduationNewSchool { get; set; }
        public string PostgraduationNewDepartment { get; set; }


        /*Connections*/
        public int? EducationId { get; set; }
        public virtual EducationInfo Education { get; set; }
        public int? BaseId { get; set; }
        public virtual BaseCard Base { get; set; }
    }
}
