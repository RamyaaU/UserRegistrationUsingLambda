using System;

namespace UserRegistrationUsingLambda
{

    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Reg using Lambda Expressions!");
            Console.WriteLine("Enter First Name :");
            string name = Console.ReadLine();
            //reference for regex class
            RegeX regex = new RegeX();
            //if regex is valid 
            //it executes as valid firstname
            //otherwise invalid firstname
            if (regex.ValidFirstName(name))
                Console.WriteLine("First Name is VALID !!");
            else
                Console.WriteLine("First Name is INVALID !!");
            Console.WriteLine("Enter Last Name :");
            //if regex is valid 
            //it executes as valid lastname
            //otherwise invalid lastname
            string lastname = Console.ReadLine();
            if (regex.ValidLastName(lastname))
                Console.WriteLine("Last Name is VALID !!");
            else
                Console.WriteLine("Last Name is INVALID !!");
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            //if regex is valid 
            //it executes as valid email
            //otherwise invalid email
            if (regex.ValidEmail(email))
                Console.WriteLine("Email is VALID !!");
            else
                Console.WriteLine("Email is INVALID !!");
            Console.WriteLine("Enter Mobile Number :");
            string mobilenum = Console.ReadLine();
            //if regex is valid 
            //it executes as valid mobileno
            //otherwise invalid mobileno
            if (regex.ValidMobile(mobilenum))
                Console.WriteLine("Mobile Number is VALID !!");
            else
                Console.WriteLine("Mobile Number is INVALID !!");
            Console.WriteLine("Enter Password :");
            string Rule1 = Console.ReadLine();
            //if regex is valid 
            //it executes as valid rule1
            //otherwise invalid rule1
            if (regex.ValidCondition1(Rule1))
                Console.WriteLine("Password is VALID !!");
            else
                Console.WriteLine("Password is INVALID !!");
        }
    }
}