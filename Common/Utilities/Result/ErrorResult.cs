using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class ErrorResult:Result
    {
        //Hata olduğu için boolun hep false dönmesi gerekiyor.
       public ErrorResult():base(false)
       {

       } 

        public ErrorResult(string message):base(false,message)
        {

        }

    }
}
