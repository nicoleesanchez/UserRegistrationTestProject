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
            string email = "nicolesanchez@gmail.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Username must be between 5 and 20 characters long.");
        }

        [TestMethod]
        public void AddUser_InvalidUsername_TooLong()
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abcdefghijklmnopqrstu"; // Too long
            string password = "password123";
            string email = "nicolesanchez@gmail.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Username must be between 5 and 20 characters long.");
        }

        [TestMethod]
        public void Password_ValidPasswordWithSpecialCharacter()  // Testar om password innehåller specialtecken
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password123!";
            string email = "nicolesanchez@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Added successfully.");
        }

        [TestMethod]
        public void Password_ValidPasswordWithoutSpecialCharacter() 
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "passw";
            string email = "nicolesanchez@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Password lenght must be over 8 characters and must include special sign");
        }

        [TestMethod]
        public void Password_TooShort() 
        {
            // Arrange
            var registrationService = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "passw!";
            string email = "nicolesanchez@gmail.com";
            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "Password lenght must be over 8 characters and must include special sign");
        }

        [TestMethod]
        public void CheckIfEmailIsCorrectFormat() //Testar om email är i rätt format @gmail.com
        {
            //Arrange
            var testDummy = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password123!";
            string email = "nicolesanchez@gmail.com";

            //Act
            string result = testDummy.AddUser(username, password, email);

            //Assert
            Assert.AreEqual(result, "User added successfully.");
        }

        [TestMethod]
        public void CheckIfEmailIsinCorrectFormat() 
        {
            //Arrange
            var testDummy = new UserRegistrationService();
            string username = "abcdefghij";
            string password = "password123!";
            string email = "test@hotmail.com";

            //Act
            string result = testDummy.AddUser(username, password, email);
            //Assert
            Assert.AreEqual(result, "Email must include @gmail.com");
        }

        [TestMethod]
        public void AddUser() 
        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string username = "abcdefghijkl"; // Too long
            string password = "password123!";
            string email = "nicolesanchez@gmail.com";

            // Act
            string result = registrationService.AddUser(username, password, email);

            // Assert
            Assert.AreEqual(result, "User added successfully.");
        }

        [TestMethod]
        public void AddUser_InvalidNonAlphanumericCharacters_ReturnFalse() 

        {
            // Arrange
            UserRegistrationService registrationService = new UserRegistrationService();
            string nonAlphanumericString = "abc$123";
            string password = "password123!";
            string email = "nicolesanchez@gmail.com";

            // Act
            bool result = registrationService.IsAlphanumeric(nonAlphanumericString);

            // Assert
            Assert.IsFalse(result, "Expected user registration to fail due to invalid characters in username.");
        }

        //[TestMethod]
        //public void IsAlphanumeric_InvalidNonAlphanumericString_ReturnsFalse() // Testar att den inte imehåller icke-alphanumeriska tecken
        //{
        //    // Arrange
        //    UserRegistrationService registrationService = new UserRegistrationService();
        //    string nonAlphanumericString = "abc$123";

        //    // Act
        //    bool result = registrationService.IsAlphanumeric(nonAlphanumericString);

        //    // Assert
        //    Assert.IsFalse(result, "Expected user registration to fail due to invalid characters in username.");
        //}
    }
}