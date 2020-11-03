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
        //pattern for valid lasttname
        public static string LastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
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
    }
}
   
