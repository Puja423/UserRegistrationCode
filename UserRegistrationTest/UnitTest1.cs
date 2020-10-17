using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using UserRegistration;
using UserRegistrationCode;
namespace UserValidationTesting
{
    [TestClass]
    public class ValidationTesting
    {
        [TestMethod]
        [DataRow("Jyoti")]
        [DataRow("JYOTI")]
        [DataRow("Jyoti Ranjan")]
        public void Test_ValidFirstNames(string fName)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyFirstName(fName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Jr")]
        [DataRow("jyoti")]
        [DataRow("Jy@ti")]
        public void Test_InvalidFirstNames(string fName)
        {
            //Arrange
            User user = new User();
            string expected = "First name needs min 3 characters and first letter in upper case";
            string actual;
            //Act
            try
            {
                actual = user.VerifyFirstName(fName).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Mishra")]
        [DataRow("MISHRA")]
        public void Test_ValidLastNames(string lName)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyLastName(lName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Mi")]
        [DataRow("mishra")]
        [DataRow("Mis#ra")]
        public void Test_InvalidLastNames(string lName)
        {
            //Arrange
            User user = new User();
            string expected = "Last name needs min 3 characters and first letter in upper case";
            string actual;
            //Act
            try
            {
                actual = user.VerifyLastName(lName).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("jrm@gmail.com")]
        [DataRow("jrm.cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in")]
        [DataRow("jrm100@gmail.com")]
        [DataRow("jrm-nit@1mg.co.in")]
        public void Test_ValidEmails(string email)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("jrm.@gmail.com")]
        [DataRow("jrm@cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in.uk")]
        [DataRow("jrm100@.gmail.com")]
        [DataRow("jrm..nit@1mg.com")]
        [DataRow("jrm.nit.@gmail.com")]
        [DataRow("jrm..nit@1mg.23")]
        public void Test_InvalidEmails(string email)
        {
            //Arrange
            User user = new User();
            string expected = "Email id should be in \" abc.xyz@bl.co.in \" format (.xyz & .in parts optional)";
            string actual;
            //Act
            try
            {
                actual = user.VerifyEmail(email).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("91 6231230127")]
        public void Test_ValidNumbers(string phNum)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPhNumber(phNum);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1234567890")]
        [DataRow("981236540987")]
        [DataRow("97 0123456789")]
        [DataRow("97 123456")]
        [DataRow("9 1234567890")]
        [DataRow("97 8123456789012")]
        [DataRow("97 123 456 6789")]
        public void Test_InvalidNumbers(string phNum)
        {
            //Arrange
            User user = new User();
            string expected = "Phone number should have 2 digit country code followed by space separated 10 digit number";
            string actual;
            //Act
            try
            {
                actual = user.VerifyPhNumber(phNum).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Had2Te#t")]
        [DataRow("had2T3stP@ss")]
        [DataRow("T3STP@SS")]
        public void Test_ValidPasswords(string pass)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPassword(pass);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Hd2T#t")] //less than 8 char
        [DataRow("had2testPass")] //no special char
        [DataRow("TestP@ss")] //no number
        [DataRow("t3stp@ss")] //no upper case
        [DataRow("T#stP@ss5")] //more than 1 special case
        public void Test_InvalidPasswords(string pass)
        {
            //Arrange
            User user = new User();
            string expected = "Password needs to have min 8 characters, at least 1 upper case character, at least 1 numeric value, exactly 1 special character";
            string actual;
            //Act
            try
            {
                actual = user.VerifyPassword(pass).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}