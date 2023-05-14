using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryPassword;

namespace ClassLibraryPasswordTests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        [TestMethod]
        public void CheckSymbolsReturnsTrue()
        {
            // Arrange
            string password = "asq123";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSymbolsReturnsFalse()
        {
            // Arrange
            string password = "asq123";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void CheckSymbolsReturnsFalsew()
        {
            // Arrange
            string password = "aasdsaasdsadsq123";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.IsFalse(actual);

        }

    }
}
