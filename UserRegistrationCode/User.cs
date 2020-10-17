using System;
using System.Collections.Generic;
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

        private bool Validate(string str, string regex)
        {
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(str);
        }

        public bool VerifyFirstName(string fName)
        {
            _regex = "^[A-Z][a-z A-Z]{2,}$";
            return Validate(fName, _regex);
        }

        public bool VerifyLastName(string lName)
        {
            _regex = "^[A-Z][a-z A-Z]{2,}$";
            return Validate(lName, _regex);
        }

        public bool VerifyEmail(string eMail)
        {
            _regex = "^[a-z0-9A-Z]+([-.+_][a-z0-9+-]+)*@[a-z0-9A-Z]+[.][a-z]{2,3}([.][a-z]{2,})?$";
            return Validate(eMail, _regex);
        }

        public bool VerifyPhNumber(string phNum)
        {
            _regex = "^[0-9]{2}[ ][1-9][0-9]{9}$";
            return Validate(phNum, _regex);
        }

        public bool VerifyPassword(string pass)
        {
            _regex = "((?=^.*[0-9].*$)(?=^.*[A-Z].*$)(?=^[a-zA-Z0-9]*[!@#$%&*+_]{1}[a-zA-Z0-9]*$).{8,})";
            return Validate(pass, _regex);
        }

        public void StoreFirstName()
        {
            while (true)
            {
                Console.WriteLine("\nThe first name should have\n" +
                        "1. Min 3 characters\n" +
                        "2. First letter in upper case\n");

                Console.Write("Enter first name : ");
                string fName = Console.ReadLine();
                if (VerifyFirstName(fName))
                {
                    _firstName = fName;
                    break;
                }
            }
        }

        public void StoreLastName()
        {
            while (true)
            {
                Console.WriteLine("\nThe last name should have\n" +
                        "1. Min 3 characters\n" +
                        "2. First letter in upper case\n");

                Console.Write("Enter last name : ");
                string lName = Console.ReadLine();

                if (VerifyLastName(lName))
                {
                    _lastName = lName;
                    break;
                }
            }
        }

        public void StoreEmail()
        {
            while (true)
            {
                Console.WriteLine("\nThe Email Id should be in \" abc.xyz@bl.co.in \" format\n" +
                    "(xyz & in parts optional)\n");

                Console.Write("Enter Email Id : ");
                string email = Console.ReadLine();

                if (VerifyEmail(email))
                {
                    _eMail = email;
                    break;
                }
            }
        }

        public void StorePhoneNumber()
        {
            _regex = "^[0-9]{2}[ ][1-9][0-9]{9}$";

            while (true)
            {
                Console.WriteLine("\nThe phone number should have\n" +
                   "1. 2 digit country code followed by space \n" +
                   "2. 10 digit number");

                Console.Write("Phone Number : ");
                string phNum = Console.ReadLine();

                if (Validate(phNum, _regex))
                {
                    _phoneNumber = phNum;
                    break;
                }
            }
        }

        public void StorePassword()
        {
            _regex = "((?=^.*[0-9].*$)(?=^.*[A-Z].*$)(?=^[a-zA-Z0-9]*[!@#$%&*+_]{1}[a-zA-Z0-9]*$).{8,})";

            while (true)
            {
                Console.WriteLine("\nPassword needs to have \n" +
                    "1. Minimum 8 characters\n" +
                    "2. At least 1 upper case character\n" +
                    "3. At least 1 numeric value\n" +
                    "4. Exactly 1 special character\n");

                Console.Write("Password : ");
                string pass = Console.ReadLine();

                if (Validate(pass, _regex))
                {
                    _password = pass;
                    Console.WriteLine("Password created successfully");
                    break;
                }
            }
        }

        public void VerifiedEmailList()
        {
            List<string> emailList = new List<string>();
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@yahoo.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@jmail.com.com");
            emailList.Add("abc+100@gmail.com");

            emailList.Add("abc");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abjr@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");
            emailList.Add("ajrc@gmail.com.1a");
            emailList.Add("abc@gmail.com.aa.au");

            _regex = "^[a-z0-9-+]+([.][a-z0-9+-]+)?@[a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";

            foreach (string email in emailList)
            {
                if (Validate(email, _regex))
                    Console.WriteLine(email + "- VALID");
                else
                    Console.WriteLine(email + "- INVALID");
            }


        }
    }
}
