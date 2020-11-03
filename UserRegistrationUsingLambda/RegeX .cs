using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    public class RegeX
    {
        //pattern for valid name
        public static string REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, REGEX);
        }
    }
}