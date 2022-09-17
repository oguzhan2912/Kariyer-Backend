using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        
        public Result(bool isSuccess, string message):this(isSuccess)
        {
            Message = message; // Mesaj da dönmek için
        }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;     //Sadece bool dönmek için.       
          
        }       

        public bool IsSuccess { get ;  }       
        public string Message { get; }


        //public T Data { get; set; }
        //public int TotalCount { get; set; }
        
        
    }
}
