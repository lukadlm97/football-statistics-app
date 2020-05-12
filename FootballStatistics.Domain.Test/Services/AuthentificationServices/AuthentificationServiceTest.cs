using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Services;
using FootballStatistics.Domain.Services.AuthenticationService;
using Microsoft.AspNet.Identity;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.Domain.Test.Services.AuthentificationServices
{
    [TestFixture]
    public class AuthentificationServiceTest
    {
        [Test]
        public async void Login_WithTheCorrectPasswordForExistingUsername_ReturnUserFroCorrectUsername()
        {
            //Arrange
            string expectedUsername = "testuser";
            string password = "testpassword";
            Mock<IDataService<User>> mockUserService = new Mock<IDataService<User>>();
            mockUserService.Setup(s => s.GetByUsername(expectedUsername)).ReturnsAsync(new User { Username = expectedUsername });
            Mock<IPasswordHasher> mockPasswordHasher = new Mock<IPasswordHasher>();
            mockPasswordHasher.Setup(s => s.VerifyHashedPassword(It.IsAny<string>(), password)).Returns(PasswordVerificationResult.Success);
            AuthenticationService authenticationService = new AuthenticationService(mockUserService.Object,mockPasswordHasher.Object);
            

            //Act
            User u = await authenticationService.Login(expectedUsername, password);

            //Assert
            string actualUsername = u.Username;
            Assert.AreEqual(expectedUsername,actualUsername);
        }
    }
}
