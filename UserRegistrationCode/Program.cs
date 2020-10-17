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
            Console.ReadKey();
        }
    }
}