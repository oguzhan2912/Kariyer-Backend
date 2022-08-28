using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
   public class SkillInfo
    {
        [Key]
        public int SkillId { get; set; }
        public int SkillName { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }

    }
}
