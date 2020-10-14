using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationCode
{
    public class User
    {
        public string firstName { get; set; }
        private string _regexFirstName = "^[A-Z][a-z]{2,}$";
<<<<<<< HEAD

=======
        public string lastName { get; set; }
        private string _regexLastName = "^[A-Z][a-z]{2,}$";
>>>>>>> UC2_VerifyLastName
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, _regexFirstName);
        }
<<<<<<< HEAD
    }



=======
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, _regexLastName);
        }
    }
>>>>>>> UC2_VerifyLastName
}
