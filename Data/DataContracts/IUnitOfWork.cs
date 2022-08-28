using Data.DataContext;
using Data.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DataContracts
{
    public interface IUnitOfWork:IDisposable
    {
        ILanguageRepository languages { get; }
        IGeneralRepository generals { get; }
        IContactRepository contacts { get; }
        IEducationRepository educations { get; }
        IEducationPostDegreeRepository educationDegrees { get; }
        void save();
    }
}
