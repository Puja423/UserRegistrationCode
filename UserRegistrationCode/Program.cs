using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex User Registration Problem");
            Patterns pattern = new Patterns();
            Console.WriteLine("Enter the first name");
            string fname = Console.ReadLine();
            pattern.ValidateName(fname);
            Console.WriteLine("Enter the Last name");
            string lastName = Console.ReadLine();
            pattern.ValidateName(lastName);
            Console.WriteLine("Enter the the email id");
            string email = Console.ReadLine();
            pattern.ValidateEmail(email);
            Console.WriteLine("Enter the the mobile num with country code");
            string mob = Console.ReadLine();
            pattern.ValidateMobile(mob);
            Console.WriteLine("Enter the password (should contain 8 or more characters)");
            string password = Console.ReadLine();
            pattern.ValidatePassword(password);
        }
    }
}
