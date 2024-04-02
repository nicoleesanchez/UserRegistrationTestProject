using System;

namespace UserRegistrationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddUser_InvalidUsername_TooShort() //för kort username
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abc"; // Too short
            string password = "password123";
            string email = "test@example.com";

            // Act
            bool result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddUser_InvalidUsername_TooLong()
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abcdefghijklmnopqrstu"; // Too long
            string password = "password123";
            string email = "test@example.com";

            // Act
            bool result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsAlphanumeric_InvalidNonAlphanumericString_ReturnsFalse()
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string nonAlphanumericString = "abc$123";

            // Act
            bool result = registrationService.IsAlphanumeric(nonAlphanumericString);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsAlphanumeric_EmptyString_ReturnsFalse()
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string emptyString = " ";

            // Act
            bool result = registrationService.IsAlphanumeric(emptyString);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Password_ValidPasswordWithSpecialCharacter_ReturnsTrue()
        {
            // Arrange
            var registrationService = new UserRegistrationService();

            // Act
            bool result = registrationService.Password("Test123!");

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Password_ValidPasswordWithoutSpecialCharacter_ReturnsFalse()
        {
            // Arrange
            var registrationService = new UserRegistrationService();

            // Act
            bool result = registrationService.Password("Test123");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfEmailIsInCorrectFormat_ShouldReturnTrue()
        {
            //Arrange
            var testDummy = new UserRegistrationService();
            var email = "nicolesanchez@gmail.com";

            //Act
            var isCorrectFormat = testDummy.CheckEmail(email);

            //Assert
            Assert.IsTrue(isCorrectFormat, "Email format is correct");
        }
    }
}