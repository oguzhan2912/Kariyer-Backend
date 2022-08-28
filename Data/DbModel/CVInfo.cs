using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class CVInfo
    {
        [Key]        
        public int CVId { get; set; }

        /*Connections*/
        public virtual ICollection<GeneralInfo> GeneralInfos { get; set; }
        public virtual ICollection<ContactInfo> ContactInfos { get; set; }
        public virtual ICollection<EducationInfo> EducationInfos { get; set; } 
        public virtual ICollection<LanguageInfo> LanguageInfos { get; set; }               
        public virtual ICollection<ReferanceInfo> ReferanceInfos { get; set; }
        public virtual ICollection<SkillInfo> SkillInfos { get; set; }
        public virtual ICollection<PostWorkInfo> PostWorkInfos { get; set; }
        public virtual ICollection<OtherInfo> OtherInfos { get; set; }

    }
}
