using Business.Contracts;
using Common.DataContracts;
using Common.Dto;
using Common.ResultConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Implementaion
{
    public class LanguageBusinessEngine : ILanguageBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public LanguageBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<LanguageDto>> GetItems()
        {
            List<LanguageDto> languages = new List<LanguageDto>();
            var data = _uow.languages.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    languages.Add(new LanguageDto()
                    {
                        LanguageId=item.LanguageId,
                        LanguageName=item.LanguageName,
                        LanguageExam=item.LanguageExam,
                        ReadingLvl=item.ReadingLvl,
                        SpeakingLvl=item.SpeakingLvl,
                        WritingLvl=item.WritingLvl,
                        UnderstandingLvl=item.UnderstandingLvl,
                        ExamResult=item.ExamResult
                    });

                }
                return new Result<List<LanguageDto>>(true, ResultConstant.RecordFound, languages);
                
            }
            return new Result<List<LanguageDto>>(false, ResultConstant.RecordNotCreated, languages);
        }

        
    }
}
