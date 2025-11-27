using System;
using System.Text.RegularExpressions;

namespace basics.applyregex
{
    internal class PhoneAndPasswordValidation
    {
        static void Main()
        {
 
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();

            if (IsValidPhone(phone))
                Console.WriteLine("Valid Phone Number ✔");
            else
                Console.WriteLine("Invalid Phone Number ✘");

            Console.WriteLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
                Console.WriteLine("Valid Password ✔");
            else
                Console.WriteLine("Invalid Password ✘");
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            string pattern = @"^[6-9]\d{9}$";

            return Regex.IsMatch(phone, pattern);
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            return Regex.IsMatch(password, pattern);
        }
    }
}

