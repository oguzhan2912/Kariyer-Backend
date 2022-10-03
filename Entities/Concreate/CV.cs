using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class CV : BaseCard
    {
        

        /*Connections*/
        public virtual ICollection<General> GeneralInfos { get; set; }
        public virtual ICollection<Contact> ContactInfos { get; set; }
        public virtual ICollection<Education> EducationInfos { get; set; } 
        public virtual ICollection<Language> LanguageInfos { get; set; }               
        public virtual ICollection<Referance> ReferanceInfos { get; set; }
        public virtual ICollection<Skill> SkillInfos { get; set; }
        public virtual ICollection<PostWork> PostWorkInfos { get; set; }
        public virtual ICollection<Other> OtherInfos { get; set; }      
        
        



    }
}
