using ModStudioLogic.BigClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudioLogic.Exceptions
{
    public class ModException : ApplicationException
    {
        public readonly ModFeature _caller;
        public readonly string _message;

        public ModException(string message, ModFeature caller) : base(message)
        {
            _caller = caller;
            _message = message;
        }
    }
}