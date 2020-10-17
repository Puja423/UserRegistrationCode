using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

    namespace UserRegistration
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to User Registration Form");
                Console.WriteLine("=================================");

                User user = new User();

                user.VerifyFirstName();
                user.VerifyLastName();
                user.VerifyEmail();
                user.VerifyPhoneNumber();
                user.VerifyPassword();

                Console.WriteLine("\nName : " + user.FirstName + " " + user.LastName);
                Console.WriteLine("Email : " + user.EMail);
                Console.WriteLine("Ph. Number : +" + user.PhoneNumber);
            }
        }
    }