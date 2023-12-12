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
        private ModFeature _caller;
        private string _message;

        public ModFeature Caller
        { get { return _caller; } }

        public String ErrorMessage
        { get { return _message; } }

        public ModException(string message, ModFeature caller) : base(message)
        {
            _caller = caller;
            _message = message;
        }
    }
}