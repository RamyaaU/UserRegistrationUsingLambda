using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingLambda
{
    public class UserRegister
    {
        //object creation
        RegeX Obj = new RegeX();
        //variable
        private string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegister"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public UserRegister(string message)
        {
            this.message = message;
        }
        public UserRegister()
        {
        }
        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <returns></returns>
        public string FirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        /// <summary>
        /// Validates last name
        /// </summary>
        /// <returns></returns>
        public string LastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        /// <summary>
        /// Validates emails
        /// </summary>
        /// <returns></returns>
        public string Email()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        /// <summary>
        /// Validates mobile number.
        /// </summary>
        /// <returns></returns>
        public string MobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        /// <summary>
        /// Validates Passwords.
        /// </summary>
        /// <returns></returns>
        public string Password()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        /// <summary>
        /// Validates Multiple-emails.
        /// </summary>
        /// <param name="e1">The e1.</param>
        /// <param name="e2">The e2.</param>
        /// <returns></returns>
        public string MultipleEmails(string e1, string e2)
        {
            //creating b1 object so that it calls validemail function with parameter e1
            bool b1 = Obj.ValidEmail(e1);
            //creating b2 object so that it calls validemail function with parameter e1
            bool b2 = Obj.ValidEmail(e2);
            //if and only if b1 and b2 is true then retunrs entry successfull 
            //else entry unsuccessfull
            if (b1 && b2)
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
    }
}