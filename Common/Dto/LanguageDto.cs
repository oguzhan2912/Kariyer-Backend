using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class LanguageDto
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public int SpeakingLvl { get; set; }
        public int ReadingLvl { get; set; }
        public int WritingLvl { get; set; }
        public int UnderstandingLvl { get; set; }
        public string LanguageExam { get; set; }
        public int ExamResult { get; set; }
    }
}
