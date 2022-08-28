using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DataContracts
{
    public interface IUnitOfWork:IDisposable
    {
        ILanguageRepository languages { get; }
        void save();
    }
}
