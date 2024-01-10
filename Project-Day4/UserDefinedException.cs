using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day4
{
    internal class UserDefinedException : Exception
    {
        public string Message { get; set; } 
        public UserDefinedException(string message) {
            this.Message = message;
        }
    }
}
