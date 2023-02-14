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
            Console.WriteLine("First Name: ");
            string pattern = "^[A-Z]{1,}[a-z]{2,}";
            string inputs = Console.ReadLine();
            ValidatePattern(inputs, pattern);
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
    }
}
