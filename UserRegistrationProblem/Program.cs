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
            Console.WriteLine("___Welcome to User Registration program---");
            ValidateRegistration.ValidateFirstName();
            ValidateRegistration.ValidateLasttName();
            Console.ReadLine();
        }
    }
}
