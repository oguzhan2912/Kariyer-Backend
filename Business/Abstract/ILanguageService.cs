using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILanguageService
    {
       
        IResult Add(Language language);
        IResult Delete(Language language);
        IResult Update(Language language);
        IDataResult<List<Language>> GetList();
        IDataResult<Language> GetById(int languageId);
        IDataResult<List<Language>> GetByExamList(string exam);
    }
}
