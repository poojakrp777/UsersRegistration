using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegister
    {
        public static string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, NAME_PATTERN);
        }
        public bool validateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, NAME_PATTERN);
        }
        public static string EMAIL_PATTERN = "^[a-z]{3,}[1-9]{1,4}[@][a-z]{4,}[.][a-z]{3,}$";
        public bool validateEmail(String email)
        {
            return Regex.IsMatch(email, EMAIL_PATTERN);
        }
        public static string MOBILENOFORMAT_PATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public bool validateMobileNoFormat(String mobileNoFormat)
        {
            return Regex.IsMatch(mobileNoFormat, MOBILENOFORMAT_PATTERN);
        }
        public static string PASSWORD_PATTERN = "^[A-Z]{1}[a-z]{6,}[0-9]{1}";
        public bool validatePassword(String password)
        {
            return Regex.IsMatch(password, PASSWORD_PATTERN);
        }
    }
}
