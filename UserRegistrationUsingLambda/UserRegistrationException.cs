using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingLambda
{
    /// <summary>
    /// Class implemented for custom exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILENUMBER,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public UserRegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
