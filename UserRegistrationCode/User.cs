using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UserRegistration;

namespace RegexUserRegistration
{
    public class Patterns
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        string mobileNo = "^[0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        string Password = "^((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@$#&*_+-]{1}[a-zA-Z0-9]).{8,})";

        public string ValidateName(string name)
        {
            try
            {
                if (name.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Name should not be empty");
                }
                else if (Regex.IsMatch(name, Name))
                {
                    Console.WriteLine("Name is valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine("Name not valid");
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Name should not be null");
            }
        }
        public string ValidateEmail(string email)
        {
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                if (Regex.IsMatch(email, EmailId))
                {
                    Console.WriteLine("Email id is valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine("Email id not valid");
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public string ValidateMobile(string mobile)
        {
            try
            {
                if (mobile.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be empty");
                }
                if (Regex.IsMatch(mobile, mobileNo))
                {
                    Console.WriteLine("mobile number is valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine("mobile number not valid");
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Mobile Number should not be null");
            }

        }
        public string ValidatePassword(string pw)
        {
            try
            {
                if (pw.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                if (Regex.IsMatch(pw, Password))
                {
                    Console.WriteLine("Password is valid");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine("Password not valid");
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }
        public bool ValidateNameUsingLambda(string name) => Regex.IsMatch(name, Name) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_NAME, "Invalid Name");
        public bool ValidateEmailUsingLambda(string email) => Regex.IsMatch(email, EmailId) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        public bool ValidateMobileUsingLambda(string mobile) => Regex.IsMatch(mobile, mobileNo) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        public bool ValidatePasswordUsingLambda(string passw) => Regex.IsMatch(passw, Password) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");


    }
}
