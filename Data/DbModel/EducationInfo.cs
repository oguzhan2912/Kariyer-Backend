using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class EducationInfo
    {

        [Key]
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
        
        /*Postgraduation*/
        public string PostgraduationName { get; set; }
        public DateTime PostgraduationGraduationDate { get; set; }
        public string PostgraduationDepartment { get; set; }
        public string PostgraduationCountry { get; set; }
        public string PostgraduationState { get; set; }
        public decimal PostgraduationGPA { get; set; }
        public string PostgraduationNewSchool { get; set; }
        public string PostgraduationNewDepartment { get; set; }

        /*PhD*/

        public string PhDName { get; set; }
        public DateTime PhDGraduationDate { get; set; }
        public string PhDDepartment { get; set; }
        public string PhDCountry { get; set; }
        public string PhDState { get; set; }
        public decimal PhDGPA { get; set; }
        public string PhDNewSchool { get; set; }
        public string PhDNewDepartment { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }
        public int? BaseId { get; set; }
        public virtual BaseCard Base { get; set; }

        public virtual ICollection<EducationDegreeInfo> EducationDegreeInfos { get; set; }
        public virtual ICollection<EducationPostDegreeInfo> EducationPostDegreeInfos { get; set; }

    }
}
