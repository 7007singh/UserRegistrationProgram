using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserMood
    {
        public string message = "I am in happy mood";
        public UserMood(string message) 
        {
            this.message = message;
        }
        public string AnalyseUserMood()
        {
            if (message.Contains("happy".ToLower()))
            {
                return "HAPPY";
            }
            else
            {   
                return "SAD";
            }
        }
    }
}
