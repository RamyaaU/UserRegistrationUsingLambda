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
        /// <summary>
        /// Checks the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <exception cref="UserRegistrationException">First Name is Invalid !!</exception>
        public void CheckFirstName(string firstName)
        {
            if (Obj.ValidFirstName(firstName))
                Console.WriteLine("Valid First Name !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "First Name is Invalid !!");
        }
        /// <summary>
        /// Checks the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <exception cref="UserRegistrationException">Last Name is Invalid !!</exception>
        public void CheckLastName(string lastName)
        {
            if (Obj.ValidLastName(lastName))
                Console.WriteLine("Valid Last Name !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Last Name is Invalid !!");
        }
        /// <summary>
        /// Checks the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <exception cref="UserRegistrationException">Email is Invalid !!</exception>
        public void CheckEmail(string email)
        {
            if (Obj.ValidEmail(email))
                Console.WriteLine("Valid Email !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Email is Invalid !!");
        }
        /// <summary>
        /// Checks the mobile.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <exception cref="UserRegistrationException">Mobile number is Invalid !!</exception>
        public void CheckMobile(string mobileNumber)
        {
            if (Obj.ValidMobile(mobileNumber))
                Console.WriteLine("Valid Mobile Number !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILENUMBER, "Mobile number is Invalid !!");
        }
        /// <summary>
        /// Checks the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <exception cref="UserRegistrationException">Password is Invalid !!</exception>
        public void CheckPassword(string password)
        {
            if (Obj.ValidCondition1(password) && Obj.ValidCondition4(password))
                Console.WriteLine("Valid Password !!");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid !!");
        }
    }
}

