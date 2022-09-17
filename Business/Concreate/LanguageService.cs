using Business.Abstract;

using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class LanguageService : ILanguageService
    {
        private ILanguageDao _languageDao;
        public LanguageService(ILanguageDao languageDao)
        {
            _languageDao = languageDao;
        }
        public IResult Add(Language language)
        {            
            _languageDao.Add(language);
            return new SuccessResult(ResultConstant.RecordCreated);

        }

        public IResult Delete(Language language)
        {            
            _languageDao.Delete(language);
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IDataResult<List<Language>> GetByExamList(string exam)
        {
            return new SuccessDataResult<List<Language>>(_languageDao.GetAll(w => w.LanguageExam== exam).ToList());
        }

        public IDataResult<Language> GetById(int languageId)
        {
            return new SuccessDataResult<Language>(_languageDao.Get(w => w.Id ==languageId)) ;
        }

        public IDataResult<List<Language>> GetList()
        {
            return new SuccessDataResult<List<Language>>(_languageDao.GetAll().ToList());
        }

        public IResult Update(Language language)
        {
            _languageDao.Update(language);
            return new SuccessResult(ResultConstant.RecordCreated);
        }
    }
}
