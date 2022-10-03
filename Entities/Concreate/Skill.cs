using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
   public class Skill : BaseCard
    {
       
        public string SkillName { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CV CVInfo { get; set; }
        

    }
}
