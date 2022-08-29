using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class EducationDegreeDto
    {
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public DateTime DegreeGraduationDate { get; set; }
        public string DegreeDepartment { get; set; }
        public string DegreeCountry { get; set; }
        public string DegreeState { get; set; }
        public decimal DegreeGPA { get; set; }
        public string DegreeNewSchool { get; set; }
        public string DegreeNewDepartment { get; set; }
    }
}
