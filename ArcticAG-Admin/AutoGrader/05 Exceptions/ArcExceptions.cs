using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcticAG_Admin
{
    public class ArcDirectoryAlreadyExistsException : Exception
    {
        public ArcDirectoryAlreadyExistsException()
        {

        }
    }

    public class ArcTooManyFilesException : Exception
    { 
        public ArcTooManyFilesException()
        {

        }
    }
}
