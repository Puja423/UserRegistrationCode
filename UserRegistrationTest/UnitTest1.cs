using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using UserRegistrationCode;


namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyFirstName_StartsWith_CapitalOrNot()
        {
            User user = new User();
            var firstName = "Puja";
            var result = user.ValidateFirstName(firstName); ;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void VerifyLastName_StartsWith_CapitalOrNot()
        {
            User user = new User();
            var lastName = "Yadav";
            var result = user.ValidateLastName(lastName); ;
        }


        [TestMethod]
        [DataRow("jrm@gmail.com")]
        [DataRow("jrm.cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in")]
        [DataRow("jrm100@gmail.com")]
        [DataRow("jrm-nit@1mg.co.in")]
        public void TestEmailValidation_ValidEmails(string email)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 6231230127")]
        public void TestPhNumberValidation_ValidNumbers(string phNum)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.ValidateMobileNumber(phNum);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Had2Te#t")]
        [DataRow("had2T3stP@ss")]
        [DataRow("T3STP@SS")]
        public void TestPasswordValidation_ValidPasswords(string pass)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.ValidatePassword(pass);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
