using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CompileErrorException : Exception
    { 
        public CompileErrorException()
        {

        }
    }

    public class ExceutionErrorException : Exception
    {
        public ExceutionErrorException()
        {

        }
    }
}
