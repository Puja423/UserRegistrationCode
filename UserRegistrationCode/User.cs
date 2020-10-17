using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {
        string _firstName;
        string _lastName;
        string _eMail;
        string _phoneNumber;
        string _password;

        string _regex = "";

        public User()
        {
            this._firstName = "";
            this._lastName = "";
            this._eMail = "";
            this._phoneNumber = "";
            this._password = "";
        }

        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string EMail { get => _eMail; }
        public string PhoneNumber { get => _phoneNumber; }

        private bool Validate(string strToValidate, string regex)
        {
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(strToValidate);
        }

        public bool VerifyFirstName(string fName)
        {
            _regex = "^[A-Z][a-z A-Z]{2,}$";
            if (Validate(fName, _regex))
                return true;
            else
            {
                string rule = "First name needs min 3 characters and first letter in upper case";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_FIRST_NAME, rule);
            }
        }

        public bool VerifyLastName(string lName)
        {
            _regex = "^[A-Z][a-z A-Z]{2,}$";
            if (Validate(lName, _regex))
                return true;
            else
            {
                string rule = "Last name needs min 3 characters and first letter in upper case";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_LAST_NAME, rule);
            }
        }

        public bool VerifyEmail(string eMail)
        {
            _regex = "^[a-z0-9A-Z]+([-.+_][a-z0-9+-]+)*@[a-z0-9A-Z]+[.][a-z]{2,3}([.][a-z]{2,})?$";
            if (Validate(eMail, _regex))
                return true;
            else
            {
                string rule = "Email id should be in \" abc.xyz@bl.co.in \" format (.xyz & .in parts optional)";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_EMAIL, rule);
            }
        }

        public bool VerifyPhNumber(string phNum)
        {
            _regex = "^[0-9]{2}[ ][1-9][0-9]{9}$";
            if (Validate(phNum, _regex))
                return true;
            else
            {
                string rule = "Phone number should have 2 digit country code followed by space separated 10 digit number";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_PHONE_NUMBER, rule);
            }
        }

        public bool VerifyPassword(string pass)
        {
            _regex = "((?=^.*[0-9].*$)(?=^.*[A-Z].*$)(?=^[a-zA-Z0-9]*[!@#$%&*+_]{1}[a-zA-Z0-9]*$).{8,})";
            if (Validate(pass, _regex))
                return true;
            else
            {
                string rule = "Password needs to have min 8 characters, at least 1 upper case character, at least 1 numeric value, exactly 1 special character";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_PASSWORD, rule);
            }
        }

        public void VerifiedEmailList(List<string> emailList)
        {
            foreach (string email in emailList)
            {
                if (VerifyEmail(email))
                    Console.WriteLine(email + "- VALID");
                else
                    Console.WriteLine(email + "- INVALID");
            }
        }
    }
}

