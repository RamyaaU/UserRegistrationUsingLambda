using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingLambda
{
    public class UserRegister
    {
        //variable
        private string message;
        //
        public UserRegister(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <returns></returns>
        public string FirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <returns></returns>
        public string LastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <returns></returns>
        public string Email()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        /// <summary>
        /// Validates mobile number
        /// </summary>
        /// <returns></returns>
        public string MobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        /// <summary>
        /// Validates the password
        /// </summary>
        /// <returns></returns>
        public string Password()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
    }
}
