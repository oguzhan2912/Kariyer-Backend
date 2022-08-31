using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class LanguageInfo
    {   
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public int SpeakingLvl { get; set; }
        public int ReadingLvl { get; set; }
        public int WritingLvl { get; set; }
        public int UnderstandingLvl { get; set; }
        public string LanguageExam { get; set; }
        public int ExamResult { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }

        public int? BaseId { get; set; }
        public virtual BaseCard Base { get; set; }

    }
}
