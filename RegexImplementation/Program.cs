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
          
                while (!(validatePinCode(pinCode)))
                {
                    Console.WriteLine("Please enter valid pin code");
                    pinCode = Console.ReadLine();
                }
                Console.WriteLine("Valide one");


           
                Console.WriteLine("Enter your Email-Id");

                string emailId = Console.ReadLine();

                while (!(validateEmailId(emailId)))
                {
                    Console.WriteLine("Please enter valid Email Id ");
                    emailId = Console.ReadLine();
                }
                Console.WriteLine("Valid one");

            

        }
        public static bool validatePinCode(string pinCode)
        {
            string pattern = @"(^[1-9]{1}[0-9]{2}[ ]{0,1}[0-9]{3}$)";
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

        public static bool validateEmailId(string emailId)
        {


           
            string pattern = "(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)";

            Regex re = new Regex(pattern);
            if (re.IsMatch(emailId))
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
