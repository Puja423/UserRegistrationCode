﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UserRegistrationCode
{
    public class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Welcome To User Registration");

            var user = new User();
            Console.Write("Enter First Name :");
            var firstName = Console.ReadLine();
            if (user.ValidateFirstName(firstName))
                user.firstName = firstName;
            else
                Console.WriteLine("Invalid first name. " +
                    "It should have minimum 3 letters and only first letter as capital");
=======
            Console.WriteLine("Welcome to User Registration!");
            var user = new User();
            Console.Write("Enter First Name :");
            var firstName = Console.ReadLine();

            if (user.ValidateFirstName(firstName))
                user.firstName = firstName;
            else
                Console.WriteLine("Invalid first name. " + "It should have minimum 3 letters and only first letter as capital");
        }
        public static void AskLastName(User user)
        {
            Console.Write("Enter Last Name :");
            var lastName = Console.ReadLine();
            if (user.ValidateLastName(lastName))
                user.lastName = lastName;
            else
                Console.WriteLine("Invalid Last name. " +
                    "It should have minimum 3 letters and only first letter as capital");

>>>>>>> UC2_VerifyLastName
        }
    }
}