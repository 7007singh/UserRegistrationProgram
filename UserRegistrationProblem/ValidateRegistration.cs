using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class ValidateRegistration
    {
        public static void ValidateFirstName()
        {
            Console.WriteLine("First Name: ");
            string pattern = "^[A-Z]{1,}[a-z]{2,}";
            string inputs = Console.ReadLine();
            ValidatePattern(inputs, pattern);
        }
        public static void ValidateLasttName()
        {
            Console.WriteLine("Last Name: ");
            string pattern = "^[A-Z]{1,}[a-z]{2,}";
            string inputs = Console.ReadLine();
            ValidatePattern(inputs, pattern);
        }
        public static void ValidateEmailId()
        {
            Console.WriteLine("Email ID: ");
            string pattern = "[a,b,c]{3}[.]*[a-z]*[@][b,l]{2}[.][c,o]{2}[.]*[a-z]*"; //abc.xyz@bl.co.in
            string inputs = Console.ReadLine();
            ValidatePattern(inputs, pattern);
        }
        public static void ValidateMobileFormat()
        {
            Console.WriteLine("Mobile Number: ");
            string pattern = "[0-9]{2}[ ]{1}[0-9]{10}";
            string inputs = Console.ReadLine();
            ValidatePattern(inputs, pattern);
        }
        public static void ValidatePassword()
        {
            Console.WriteLine("Password: ");
            string pattern = "(?=.*[A-Z])(?=.*[0-9])(?=.*[@,#,$,&]{1})[a-zA-Z0-9].{8,}$";
            string inputs = Console.ReadLine();
            ValidatePattern(inputs, pattern);
        }
        public static void ValidateAllEmail()
        {
            Console.WriteLine("Validation of input");
            string pattern = "^[a,b,c]{3}[-.+]*[0-9]*[@]{1}[a-z0-9]*[.][a-z[.]*[a-z]*";
            string[] inputs = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmai.com.com","abc+100@gmail.com" };
            ValidateAllMail(inputs, pattern);
        }
        public static void ValidatePattern(string inputs, string pattern)
        {
            if (Regex.IsMatch(inputs, pattern))
            {
                Console.WriteLine("{0} is valid ", inputs);
            }
            else
            {
                Console.WriteLine("{0} is invalid ", inputs);
            }
        }
        public static void ValidateAllMail(string[] inputs, string pattern)
        {
            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("valid: "+ input);
                }
                else
                {
                    Console.WriteLine("Invalid: "+ input);
                }
            }
        }
    }
}
