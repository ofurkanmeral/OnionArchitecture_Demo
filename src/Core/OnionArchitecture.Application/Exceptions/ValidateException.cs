using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Exceptions
{
    public class ValidateException:Exception
    {
        public ValidateException():this("Validation Error Occured")
        {

        }
        public ValidateException(string message) : base(message)
        {

        }
        public ValidateException(Exception ex) : this(ex.Message)
        {

        }
    }
}
