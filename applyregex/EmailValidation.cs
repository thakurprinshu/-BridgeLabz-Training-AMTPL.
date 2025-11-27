using System;
using System.Text.RegularExpressions;

namespace basics.applyregex
{
    internal class EmailValidation
    {
        static void Main()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("Valid Email ✔");
            }
            else
            {
                Console.WriteLine("Invalid Email ✘");
            }
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // STRONGER REGEX PATTERN
            string pattern = @"^[a-zA-Z0-9]+([._%+-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
