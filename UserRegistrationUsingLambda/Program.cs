using System;

namespace UserRegistrationUsingLambda
{
    class Program
    {
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
        }
    }
}
