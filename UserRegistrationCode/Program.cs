using System;

namespace UserRegistrationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");

            var user = new User();
            Console.Write("Enter First Name :");
            var firstName = Console.ReadLine();
            if (user.ValidateFirstName(firstName))
                user.firstName = firstName;
            else
                Console.WriteLine("Invalid first name. " +
                    "It should have minimum 3 letters and only first letter as capital");
        }
    }
}
