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
        //pattern for valid mobile mo with country code
        public static string MobileNumREGEX = "^[9]{1}[1]{1}[ ]{1}[6-9]{1}[0-9]{9}$";
        //pattern for valid email
        public static string EmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        //pattern for valid rule1
        public static string Condition1REGEX = "^[A-Za-z0-9@$!%*#?&]{8,}$";
        //pattern for valid rule2
        public static string Condition2REGEX = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";
        //pattern for valid rule3
        public static string Condition3REGEX = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9@$!%*#?&]{8,}$";
        //pattern for valid rule4
        public static string Condition4REGEX = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";
        //pattern for sample email
        public static string SampleEmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

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
        /// Valids the mobile.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns></returns>
        public bool ValidMobile(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobileNumREGEX); ;
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
        /// <summary>
        /// Valids the condition3.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidCondition3(string password)
        {
            return Regex.IsMatch(password, Condition3REGEX); ;
        }
        /// <summary>
        /// Valids the condition4.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidCondition4(string password)
        {
            return Regex.IsMatch(password, Condition4REGEX); ;
        }
        /// <summary>
        /// Samples the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool SampleEmail(string email)
        {
            return Regex.IsMatch(email, SampleEmailREGEX); ;
        }
        /// <summary>
        /// Validating  the firstname using lambda expression
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Func<string, bool> isValidFirstName = firstname => Regex.IsMatch(firstname, FirstNameREGEX);

        /// <summary>
        /// Validating  the lastname using lambda expression
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Func<string, bool> isValidLastName = lastname => Regex.IsMatch(lastname, LastNameREGEX);


        /// <summary>
        /// Validating  the email using lambda expression
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EmailREGEX);


        /// <summary>
        /// Validating  the mobile number using lambda expression
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Func<string, bool> isValidMobileNumber = mobilenumber => Regex.IsMatch(mobilenumber, MobileNumREGEX);

        /// <summary>
        /// Validating  the password using lambda expression
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Func<string, bool> isValidPassword = password => Regex.IsMatch(password, Condition1REGEX) && Regex.IsMatch(password, Condition4REGEX);
    }
}
