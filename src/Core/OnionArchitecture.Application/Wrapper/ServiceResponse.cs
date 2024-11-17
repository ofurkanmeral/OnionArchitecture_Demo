using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrapper
{
    public class ServiceResponse<T>
    {
        public T _value { get; set; }

        public ServiceResponse(T value)
        {
            _value = value;
        }
        public ServiceResponse() { }
    }
}
