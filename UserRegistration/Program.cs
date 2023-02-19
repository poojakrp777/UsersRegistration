﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration validation");

            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();

            UserRegister userRegister = new UserRegister();
            Console.WriteLine(userRegister.validateFirstName(firstName));
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegister.validateLastName(lastName));
            Console.WriteLine("Enter the email = ");
            string email = Console.ReadLine();
            Console.WriteLine(userRegister.validateEmail(email));
            Console.ReadLine();
        }
    }
}
