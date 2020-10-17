using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using UserRegistration;

namespace UserValidationTesting
{
    [TestClass]
    public class ValidationTesting
    {
        [TestMethod]
        public void Test_ValidFirstName()
        {
            //Arrange
            string fName = "Jyoti";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyFirstName(fName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_InvalidFirstName()
        {
            //Arrange
            string fName = "jyoti";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyFirstName(fName);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ValidLastName()
        {
            //Arrange
            string lName = "Mishra";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyLastName(lName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_InvalidLastName()
        {
            //Arrange
            string lName = "mishra";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyLastName(lName);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ValidEmail()
        {
            //Arrange
            string email = "jrm@gmail.co.in";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_InvalidEmail()
        {
            //Arrange
            string email = "jrm..100@gmail.co.in";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyEmail(email);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ValidNumber()
        {
            //Arrange
            string phNum = "91 6231230127";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPhNumber(phNum);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_InvalidNumber()
        {
            //Arrange
            string phNum = "97 8123456789012";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPhNumber(phNum);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ValidPassword()
        {
            //Arrange
            string pass = "Had2Te#t";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPassword(pass);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_InvalidPassword()
        {
            //Arrange
            string pass = "Hd2T#t";
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPassword(pass);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

    }
}