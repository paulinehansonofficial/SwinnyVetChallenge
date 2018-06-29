using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace SwinnyVetAPI.Exceptions
{
    public class NotIntegerException : Exception
    {
        public NotIntegerException(string input) : base("NotIntegerException: " + input) { }

    }

    public class NullValueException : Exception
    {
        public NullValueException(string input) : base("NullValueException: " + input) { }

    }

    public class ValidationFailureException : Exception
    {
        public ValidationFailureException(string input) : base("ValidationException: " + input) { }

    }

}

