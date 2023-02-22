using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace User_Registration_Using_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        // test case for First Name
        [TestMethod]
        public void GivenWrongFirstName_ShouldReturnFalse()
        {
            //Arrange
            string firstName = "pooja";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateFirstName(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectFirstName_ShouldReturnTrue()
        {
            //Arrange
            string firstName = "Pooja";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateFirstName(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // test case for last name
        [TestMethod]
        public void GivenWrongLastName_ShouldReturnFalse()
        {
            //Arrange
            string lastName = "gowda";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateLastName(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectLastName_ShouldReturnTrue()
        {
            //Arrange       
            string lastName = "Gowda";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateLastName(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test case for Email
        [TestMethod]
        public void GivenWrongEmail_ShouldReturnFalse()
        {
            //Arrange
            string Email = "poo@gmail.com";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateEmail(Email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectEmail_ShouldReturnTrue()
        {
            //Arrange
            string Email = "pooja123@gmail.com";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateEmail(Email);
            //Assert         
            Assert.AreEqual(expected, actual);
        }

        //Test case for Phone Number
        [TestMethod]
        public void GivenWrongPhoneNumber_ShouldReturnFalse()
        {
            //Arrange
            string phoneNumber = "952911129589";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectPhoneNumber_ShouldReturnTrue()
        {
            //Arrange
            string phoneNumber = "91 9529111295";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Test case for Password
        [TestMethod]
        public void GivenWrongPassword_ShouldReturnFalse()
        {
            //Arrange
            string Password = "pass123";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidatePassword(Password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectPassword_ShouldReturnTrue()
        {
            //Arrange
            string Password = "Pass@123";
            UserRegistration1 userRegistration = new UserRegistration1();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidatePassword(Password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenParameterizedTest_ToCheckValidMultipleEntries_ReturnEntryIsSucessful()
        {
            RegistrationCheck registrationCheck = new RegistrationCheck();
            var result = registrationCheck.CheckMultipleEntriesOfEmail("abc@yahoo.com", "abc-100@yahoo.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@1.com");
            Assert.AreEqual(result, "Entry is successful");
        }

        [TestMethod]
        public void GivenParameterizedTest_ToCheckInvalidMultipleEntries_ReturnEntryIsNotSucessful()
        {
            RegistrationCheck registrationCheck = new RegistrationCheck();
            var result = registrationCheck.CheckMultipleEntriesOfEmail("abc", "abc123@gmail.a", "abc@.com.my", "abc123@.com", "abc123@.com.com");
            Assert.AreEqual(result, "Entry is not successful");
        }
    }
}