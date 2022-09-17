using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool isSuccess ) : base(isSuccess)
        {
            Data = data;// base classımda bool döndüğü içir bir kez daha döndürmüyorum.
        }

        public DataResult(T data, bool isSuccess, string message): base(isSuccess,message)
        {
            Data = data;// base classımda bool ve mesaj döndüğü için bir kez daha döndürmeme gerek yok.
        }

        public T Data { get; }
    }
}
