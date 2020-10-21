using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUserRegistration;
using UserRegistration;

namespace UserRegistrationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void when_all_Details_in_correct_format_should_return_Valid()
        {
            Patterns pattern = new Patterns();
            string firstNameTest = pattern.ValidateName("Ramesh");
            string lastNameTest = pattern.ValidateName("Verma");
            string mobileTest = pattern.ValidateMobile("91 7342043811");
            string emailTest = pattern.ValidateEmail("mihir2233@gmail.com");
            string passTest = pattern.ValidatePassword("ABcde@123");
            Assert.AreEqual("Valid", firstNameTest);
            Assert.AreEqual("Valid", lastNameTest);
            Assert.AreEqual("Valid", mobileTest);
            Assert.AreEqual("Valid", emailTest);
            Assert.AreEqual("Valid", passTest);
        }
        [TestMethod]
        public void when_any_Detail_is_not_in_correct_format_should_return_Invalid()
        {
            Patterns pattern = new Patterns();
            string firstNameTest = pattern.ValidateName("Ra");
            string lastNameTest = pattern.ValidateName("V");
            string mobileTest = pattern.ValidateMobile("91 7342811");
            string emailTest = pattern.ValidateEmail("mihir@gmail");
            string passTest = pattern.ValidatePassword("abcde");
            Assert.AreEqual("Invalid", firstNameTest);
            Assert.AreEqual("Invalid", lastNameTest);
            Assert.AreEqual("Invalid", mobileTest);
            Assert.AreEqual("Invalid", emailTest);
            Assert.AreEqual("Invalid", passTest);
        }
        [TestMethod]
        [DataRow("xyz@gmail.com")]
        [DataRow("xyz123@gmail.com")]
        [DataRow("xyz123pqr@gmail.com")]
        [DataRow("abc123@gml.com")]
        [DataRow("abc.123@gmail.co.in")]
        public void Validate_Multiple_Email_Enteries(string email)
        {
            Patterns pattern = new Patterns();
            string result = pattern.ValidateEmail(email);
            Assert.AreEqual("Valid", result);
        }
        [TestMethod]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string name = string.Empty;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string name = null;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string name = string.Empty;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string name = null;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string email = string.Empty;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                string email = null;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email should not be null", e.Message);
            }
        }
        public void Given_Empty_Mobile_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string mobile = string.Empty;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateMobile(mobile);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Mobile Number should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Mobile_Should_Throw_UserRegistrationException()
        {
            try
            {
                string mobile = null;
                Patterns pattern = new Patterns();
                string result = pattern.ValidateMobile(mobile);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Mobile Number should not be null", e.Message);
            }
        }
        public void Given_Empty_Password_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string pw = string.Empty;
                Patterns pattern = new Patterns();
                string result = pattern.ValidatePassword(pw);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Password_Should_Throw_UserRegistrationException()
        {
            try
            {
                string pw = null;
                Patterns pattern = new Patterns();
                string result = pattern.ValidatePassword(pw);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password should not be null", e.Message);
            }
        }
    }
}