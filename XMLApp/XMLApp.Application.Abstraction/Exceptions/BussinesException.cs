using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp.Application
{
    public class BussinesException : Exception
    {
        public int Number { get; set; }
        public string ExceptionMessage { get; set; }

        public BussinesException(int number, string message) : base(string.Format("({0}) {1}", number.ToString(), message))
        {
            Number = number;
            ExceptionMessage = message;
        }
        public BussinesException(string message)
         : base(string.Format(message))
        {
            ExceptionMessage = message;
        }
    }
}
