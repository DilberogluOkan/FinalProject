using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
      
        public Result(bool success, string message):this(success)//iki parametre gönderirlerse this success e alttakini kullan demek
        {
            Message = message;
           
        }
        public Result(bool success)
        {
            Succes=success;
        }

        public bool Succes { get; }

        public string Message { get; }
    }
}
