using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryPassword;

namespace ClassLibraryPasswordTests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        [TestMethod]
        public void ValidatePasswordTest()
        {
            // Arrange
            string password = "$ASDddd34";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestLowLengthFalse()
        {
            // Arrange
            string password = "asd";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordLength(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestHighLengthFalse()
        {
            // Arrange
            string password = "asdasdasdasdasdsdewqewqe";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordLength(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestNumberTrue()
        {
            // Arrange
            string password = "qwerty133";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordNumber(password);


            // Assert
            Assert.AreEqual(expected, actual);
        } 
        
        [TestMethod]
        public void ValidatePasswordTestNumberFalse()
        {
            // Arrange
            string password = "qwertyddfsdf";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordNumber(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestSymbolsTrue()
        {
            // Arrange
            string password = "qwertyujhg$";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordSymbols(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestSymbolsFalse()
        {
            // Arrange
            string password = "qwERTRtyujhg23";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordSymbols(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestUpperTrue()
        {
            // Arrange
            string password = "qwert12$QD";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordUpper(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestUpperFalse()
        {
            // Arrange
            string password = "qwert12$bb";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordUpper(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestLowerTrue()
        {
            // Arrange
            string password = "QWEWQEFdsd2";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordLower(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestLowerFalse()
        {
            // Arrange
            string password = "QWERTYSDFDF";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.PasswordLower(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
