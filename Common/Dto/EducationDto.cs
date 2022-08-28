using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class EducationDto
    {
        public int EducationId { get; set; }
        /*Primary*/
        public string PrimarySchoolName { get; set; }
        public DateTime PrimaryGraduationDate { get; set; }
        /*Secondary*/
        public string SecondarySchoolName { get; set; }
        public DateTime SeondaryGraduationDate { get; set; }
        /*High*/
        public string HighSchoolName { get; set; }
        public DateTime HighGraduationDate { get; set; }
        /*Associate*/
        public string AssociateName { get; set; }
        public DateTime AssociateGraduationDate { get; set; }
        public string AssociateDepartment { get; set; }
        public string AssociateCountry { get; set; }
        public string AssociateState { get; set; }
        public decimal AssociateGPA { get; set; }
        public string AssociateNewSchool { get; set; }
        public string AssociateNewDepartment { get; set; }       
        
        /*PhD*/

        public string PhDName { get; set; }
        public DateTime PhDGraduationDate { get; set; }
        public string PhDDepartment { get; set; }
        public string PhDCountry { get; set; }
        public string PhDState { get; set; }
        public decimal PhDGPA { get; set; }
        public string PhDNewSchool { get; set; }
        public string PhDNewDepartment { get; set; }

    }
}
