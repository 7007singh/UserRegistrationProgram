using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome to User Registration program___");
            while (true)
            {
                Console.WriteLine("Choose the prigram to validate\n1.Validate first name\n2.Validate second name\n3.Validate email id" +
                    "\n4.Validate mobile number\n5.validate password\n6.Validate all email");
                ValidateRegistration validateRegistration = new ValidateRegistration();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        validateRegistration.ValidateFirstName();
                        break;
                    case 2:
                        validateRegistration.ValidateLasttName();
                        break;
                    case 3:
                        validateRegistration.ValidateEmailId();
                        break;
                    case 4:
                        validateRegistration.ValidateMobileFormat();
                        break;
                    case 5:
                        validateRegistration.ValidatePassword();
                        break;  
                    case 6:
                        validateRegistration.ValidateAllEmail();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
