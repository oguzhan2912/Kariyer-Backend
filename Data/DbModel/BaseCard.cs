using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class BaseCard
    {

        [Key]
        public int CardID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int UserID { get; set; }
        public string TaskType { get; set; }

        //connections

        public virtual CVInfo CV { get; set; }
        public virtual ContactInfo Contact { get; set; }
        public virtual EducationDegreeInfo EducationDegree { get; set; }
        public virtual EducationInfo Education { get; set; }
        public virtual EducationPostDegreeInfo EducationPostDegree { get; set; }
        public virtual GeneralInfo General { get; set; }
        public virtual LanguageInfo Language { get; set; }
        public virtual OtherInfo Other { get; set; }
        public virtual PostWorkInfo PostWork { get; set; }
        public virtual ReferanceInfo Referance { get; set; }
        public virtual SkillInfo Skill { get; set; }
        



    }
}
