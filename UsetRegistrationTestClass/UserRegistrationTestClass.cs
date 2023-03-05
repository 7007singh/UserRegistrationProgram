using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationProblem;

namespace UsetRegistrationTestClass
{
    [TestClass]
    public class ValidateUserDetailsTestClass
    {
        [TestMethod]
        [DataRow("I am in happy mood", "HAPPY")]
        public void ValidateEntry(string message, string expected)
        {
            UserMood userMood = new UserMood(message);//Act
            string actual = userMood.AnalyseUserMood();//Arrange
            Assert.AreEqual(expected, actual);//Assert
        }
    }
}
