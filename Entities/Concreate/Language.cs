using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class Language : BaseCard
    {   
        
        public string LanguageName { get; set; }
        public int SpeakingLvl { get; set; }
        public int ReadingLvl { get; set; }
        public int WritingLvl { get; set; }
        public int UnderstandingLvl { get; set; }
        public string LanguageExam { get; set; }
        public int ExamResult { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CV CVInfo { get; set; }

           

    }
}
