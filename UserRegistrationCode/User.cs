using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
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

        public void VerifyFirstName()
        {
            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            _regex = "^[A-Z][a-z A-Z]{2,}$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(fName))
                _firstName = fName;
            else
            {
                Console.WriteLine("The first name should have\n" +
                    "1. Min 3 characters\n" +
                    "2. First letter in upper case");
                VerifyFirstName();
            }
        }

        public void VerifyLastName()
        {
            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();
            _regex = "^[A-Z][a-zA-Z]{2,}$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(lName))
                _lastName = lName;
            else
            {
                Console.WriteLine("The last name should have\n" +
                    "1. Min 3 characters\n" +
                    "2. First letter in upper case");
                VerifyLastName();
            }
        }

        public void VerifyEmail()
        {
            Console.Write("Enter Email Id : ");
            string email = Console.ReadLine();
            _regex = "^[a-z0-9-+]+([.][a-z0-9+-]+)?@[a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(email))
                _eMail = email;
            else
            {
                Console.WriteLine("The Email Id should be in \" abc.xyz@bl.co.in \" format\n" +
                    "(xyz & in parts optional)");
                VerifyEmail();
            }
        }

        public void VerifyPhoneNumber()
        {
            Console.Write("Phone Number : ");
            string phNum = Console.ReadLine();
            _regex = "^[0-9]{2} [0-9]{10}$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(phNum))
                _phoneNumber = phNum;
            else
            {
                Console.WriteLine("The phone number should have\n" +
                    "1. 2 digit country code followed by space \n" +
                    "2. 10 digit number");
                VerifyPhoneNumber();
            }
        }

        private bool VerifyRule1(string pass)
        {
            _regex = "^[A-Za-z0-9_@#$%&*-]{8,}$";
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(pass);
        }

        private bool VerifyRule2(string pass)
        {
            _regex = "^.*[A-Z]+.*$";
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(pass);
        }

        private bool VerifyRule3(string pass)
        {
            _regex = "^.*[0-9]+.*$";
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(pass);
        }

        private bool VerifyRule4(string pass)
        {
            _regex = "^[A-Za-z0-9]*[!@#$%&*_-][A-Za-z0-9]*$";
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(pass);
        }

        public void VerifyPassword()
        {
            Console.WriteLine("Password needs to have \n" +
                    "1. Minimum 8 characters\n" +
                    "2. At least 1 upper case character\n" +
                    "3. At least 1 numeric value\n" +
                    "4. Exactly 1 special character\n");

            Console.Write("Password : ");
            string pass = Console.ReadLine();

            if (VerifyRule1(pass) && VerifyRule2(pass) && VerifyRule3(pass) && VerifyRule4(pass))
            {
                _password = pass;
                Console.WriteLine("Password created successfully");
            }
            else
            {
                VerifyPassword();
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
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");

            emailList.Add("abc");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abc@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");
            emailList.Add("abc@gmail.com.1a");
            emailList.Add("abc@gmail.com.aa.au");

            _regex = "^[a-z0-9-+]+([.][a-z0-9+-]+)?@[a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";
            Regex rgxObj = new Regex(_regex);

            foreach (string email in emailList)
            {
                if (rgxObj.IsMatch(email))
                    Console.WriteLine(email + "- VALID");
                else
                    Console.WriteLine(email + "- INVALID");
            }


        }

    }
}
