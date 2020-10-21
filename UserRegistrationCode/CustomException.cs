using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT,
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private readonly ExceptionType type;
        public UserRegistrationCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
