using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class LanguageService : ILanguageService
    {
        private ILanguageDao _languageDao; //İlk Olarak imp edilen interfaceden bir field tanımladık.
        public LanguageService(ILanguageDao languageDao)
        {
            _languageDao = languageDao;//Tanımladığımız field'ı parametreye atadık.
        }
        public IResult Add(Language language)
        {            
            _languageDao.Add(language);//Entity Frameworku kullanarak Add metodu ile kolay bir şekilde sace işlemi yaptık.
            return new SuccessResult(ResultConstant.RecordCreated);
        }

        public IResult Delete(Language language)
        {
            language.IsDeleted = 1;
            _languageDao.Update(language);
            return new SuccessResult(ResultConstant.RecordDeleted);
        }

        public IDataResult<List<Language>> GetByExamList(string exam)
        {
            return new SuccessDataResult<List<Language>>(_languageDao.GetAll(w => w.LanguageExam== exam).ToList());//o propertye ait bütün değerleri döndürme
        }

        public IDataResult<Language> GetById(int languageId)
        {
            return new SuccessDataResult<Language>(_languageDao.Get(w => w.Id ==languageId)) ;//tek bir property döndürme
        }

        public IDataResult<List<Language>> GetList()
        {
            return new SuccessDataResult<List<Language>>(_languageDao.GetAll(w => w.IsDeleted == 0).ToList());//bütün listeyi döndürme
        }

        public IResult Update(Language language)
        {
            _languageDao.Update(language);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }

        public IResult UpdateDelete(Language language)
        {
            _languageDao.Update(language);
            return new SuccessResult(ResultConstant.RecordUpdated);
        }
    }
}

