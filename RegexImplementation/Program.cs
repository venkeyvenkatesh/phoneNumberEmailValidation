using System;
using System.Text.RegularExpressions;

namespace RegexImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a pincode number");

            string pinCode = Console.ReadLine();

            while(!(validatePinCode(pinCode)))
            {
                Console.WriteLine("Please enter valid pin code");
                pinCode = Console.ReadLine();
            }
            Console.WriteLine("Valide one");

           

        }
        public static bool validatePinCode(string pinCode)
        {
            string pattern = @"(^[a-zA-Z0-9!@#$%^&*()-+=]{6}$)";
            Regex re = new Regex(pattern);
            if (re.IsMatch(pinCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
