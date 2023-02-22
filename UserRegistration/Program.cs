using System;
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

            UserRegister userRegister = new UserRegister();
            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            Console.WriteLine(userRegister.validateFirstName(firstName));

            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegister.validateLastName(lastName));

            Console.WriteLine("Enter the email = ");
            string email = Console.ReadLine();
            Console.WriteLine(userRegister.validateEmail(email));

            Console.WriteLine("Enter the mobile no format = ");
            string mobileNoFormat = Console.ReadLine();
            Console.WriteLine(userRegister.validateMobileNoFormat(mobileNoFormat));

            Console.WriteLine("Enter the password = ");
            string password = Console.ReadLine();
            Console.WriteLine(userRegister.validatePassword(password));

            Console.WriteLine("Email sample validator");
            EmailSample emailSamples = new EmailSample();
            emailSamples.validateEmail();
            Console.ReadLine();
        }
    }
}
