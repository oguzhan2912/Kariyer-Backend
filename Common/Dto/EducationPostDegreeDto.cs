using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class EducationPostDegreeDto
    {
        public int PostgraduationId { get; set; }
        public string PostgraduationName { get; set; }
        public DateTime PostgraduationGraduationDate { get; set; }
        public string PostgraduationDepartment { get; set; }
        public string PostgraduationCountry { get; set; }
        public string PostgraduationState { get; set; }
        public decimal PostgraduationGPA { get; set; }
        public string PostgraduationNewSchool { get; set; }
        public string PostgraduationNewDepartment { get; set; }
    }
