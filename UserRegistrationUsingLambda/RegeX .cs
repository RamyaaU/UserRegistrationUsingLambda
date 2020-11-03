using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    public class RegeX
    {
        //pattern for valid firstname
        public static string FirstNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        //pattern for valid lastname
        public static string LastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        //pattern for valid email
        public static string EmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        /// <summary>
        /// Valids the first name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, FirstNameREGEX);
        }

        /// <summary>
        /// Valids the last name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool ValidLastName(string name)
        {
            return Regex.IsMatch(name, LastNameREGEX);
        }
        /// <summary>
        /// Valids the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, EmailREGEX); 
        }
    }
}
