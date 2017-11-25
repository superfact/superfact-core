using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFact.WebApi.Api
{
    public class SuperFactException : Exception
    {
        public SuperFactException()
        { }

        public SuperFactException(string message)
        : base(message)
        { }

        public SuperFactException(string message, Exception innerException)
        : base(message, innerException)
        { }
    }
}
