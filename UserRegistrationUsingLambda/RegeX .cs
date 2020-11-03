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
        //pattern for valid rule1
        public static string Condition1REGEX = "^[A-Za-z0-9@$!%*#?&]{8,}$";
        //pattern for valid rule2
        public static string Condition2REGEX = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";



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
        /// <summary>
        /// Valids the condition1.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidCondition1(string password)
        {
            return Regex.IsMatch(password, Condition1REGEX); ;
        }
        /// <summary>
        /// Valids the condition2.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidCondition2(string password)
        {
            return Regex.IsMatch(password, Condition2REGEX); ;
        }
    }
}
