using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using UserRegistrationProblem;

namespace UserRegistrationTestProject
{
    [TestClass]
    public class UserDetailValidateTestClass
    {
        [TestMethod]
        [DataRow("I am in happy mood", "HAPPY")]
        public void Validate_User_Entry(string message, string expected)
        {
            UserMood userMood = new UserMood(message);
            string actual = userMood.AnalyseUserMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Shree", "^[A-Z]{1,}[a-z]{2,}", true)]
        public void Validate_UserEntry_FirstName(string input, string pattern, bool expected)
        {
            ValidateRegistration validateRegistration = new ValidateRegistration();
            bool actual = validateRegistration.ValidatePattern(input, pattern);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("Singh", "^[A-Z]{1,}[a-z]{2,}", true)]
        public void Validate_UserEntry_LastName(string input, string pattern, bool expected)
        {
            ValidateRegistration validateRegistration = new ValidateRegistration();
            bool actual = validateRegistration.ValidatePattern(input, pattern);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "[a,b,c]{3}[.]*[a-z]*[@][b,l]{2}[.][c,o]{2}[.]*[a-z]*", true)]
        public void Validate_UserEntry_Email(string input, string pattern, bool expected)
        {
            ValidateRegistration validateRegistration = new ValidateRegistration();
            bool actual = validateRegistration.ValidatePattern(input, pattern);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("91 9999999999", "[0-9]{2}[ ]{1}[0-9]{10}", true)]
        public void Validate_UserEntry_Mobile(string input, string pattern, bool expected)
        {
            ValidateRegistration validateRegistration = new ValidateRegistration();
            bool actual = validateRegistration.ValidatePattern(input, pattern);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("Abcdef@123", "(?=.*[A-Z])(?=.*[0-9])(?=.*[@,#,$,&]{1})[a-zA-Z0-9].{8,}$", true)]
        public void Validate_UserEntry_Password(string input, string pattern, bool expected)
        {
            ValidateRegistration validateRegistration = new ValidateRegistration();
            bool actual = validateRegistration.ValidatePattern(input, pattern);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow("^[a,b,c]{3}[-.+]*[0-9]*[@]{1}[a-z0-9]*[.][a-z[.]*[a-z]*[,]*", "valid")]
        public void ParameterisedTest_to_Validate_MultipleEntry_ForEmailAddress(string pattern, string expected)
        {
            string[] inputEmails = { "abc@yahoo.com,", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc111@abc.com,", "abc-100@abc.net,", "abc.100@abc.com.au", "abc@1.com,", "abc@gmai.com.com", "abc+100@gmail.com" };
            ValidateRegistration validateRegistration = new ValidateRegistration();
            string actual = validateRegistration.ValidateAllMail(inputEmails, pattern);
            Assert.IsTrue(Regex.IsMatch(actual, expected));
        }
    }
}
