using Business.Abstract;

using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class LanguageService : IService<Language>
    {
        /*
        private readonly IUnitOfWork _uow;

        public LanguageBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        */
        public Result<List<Language>> GetItems()
        {
            Language languages = new Language();
            var data = languages;//;.GetAll().ToList();
            if (data != null)
            {/*
                List<Language> returnModel = new List<Language>();
                foreach (var item in data)
                {
                    returnModel.Add(new Language()
                    {
                        Id = item.Id,
                        LanguageName=item.LanguageName,
                        ReadingLvl=item.ReadingLvl,
                        SpeakingLvl=item.SpeakingLvl,
                        UnderstandingLvl=item.UnderstandingLvl,
                        WritingLvl=item.WritingLvl,
                        CVId=item.CVId,
                    }); 
                }*/
                return new Result<List<Language>>(true, ResultConstant.RecordFound);
            }
            return new Result<List<Language>>(false, ResultConstant.RecordNotCreated);
        }
        public Result<bool> SaveLanguage(Language language)
        {
            try
            {
                Language languageModel = new Language();

                
                languageModel.LanguageName = language.LanguageName;
                languageModel.Id = Convert.ToInt32(language.Id);
                languageModel.ReadingLvl = language.ReadingLvl;
                languageModel.SpeakingLvl = language.SpeakingLvl;
                languageModel.UnderstandingLvl = language.UnderstandingLvl;
                languageModel.WritingLvl = language.WritingLvl;
                
                /*
                _uow.languages.Add(languageModel);                
                _uow.Save();
                               */

                return new Result<bool>(true, ResultConstant.RecordCreated);
            }
            catch (System.Exception ex)
            {

                return new Result<bool>(false, ex.Message.ToString());
            }
        }
    }
}
