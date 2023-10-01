using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcticAG_Client
{
    public class ArcConnectionAlreadyEstablishedException : Exception
    {
        public ArcConnectionAlreadyEstablishedException()
        {

        }
    }

    public class ArcLoginConnectionErrorException : Exception
    {
        public ArcLoginConnectionErrorException()
        {

        }
    }
    public class ArcInvalidConnectionException : Exception
    {
        public ArcInvalidConnectionException()
        {

        }
    }
}
