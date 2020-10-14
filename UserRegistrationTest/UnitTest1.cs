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
    }
}
