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
<<<<<<< HEAD
            Console.WriteLine("___Welcome to User Registration program---");
            ValidateRegistration.ValidateFirstName();
            ValidateRegistration.ValidateLasttName();
            ValidateRegistration.ValidateEmailId();
            ValidateRegistration.ValidateMobileFormat();
            ValidateRegistration.ValidatePassword();
=======
            Console.WriteLine("___Welcome to User Registration program___");
            Console.WriteLine("Choose the prigram to validate\n1.Validate first name\n2.Validate second name\n3.Validate email id" +
                "\n4.Validate mobile number\n5.validate password");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ValidateRegistration.ValidateFirstName();
                    break;
                case 2:
                    ValidateRegistration.ValidateLasttName();
                    break;
                case 3:
                    ValidateRegistration.ValidateEmailId();
                    break;
                case 4:
                    ValidateRegistration.ValidateMobileFormat();
                    break;
                case 5:
                    ValidateRegistration.ValidatePassword();
                    break;
            }
>>>>>>> UC4-ValidateMobileNumber
            Console.ReadLine();
        }
    }
}
