using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingLambda;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the method and returns happy if entry is successfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod1(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.FirstName();
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }

        /// <summary>
        /// Tests the method and returns sad if entry is unsuccessfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod2(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.FirstName();
            //Assert
            Assert.AreEqual("Entry Unsuccessful", result);
        }
        /// <summary>
        /// Tests the method and returns happy if entry is successfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod3(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.LastName();
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }

        /// <summary>
        /// Tests the method and returns sad if entry is unsuccessfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod4(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.LastName();
            //Assert
            Assert.AreEqual("Entry Unsuccessful", result);
        }

        /// <summary>
        /// Tests the method and returns happy if entry is successfull
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod5(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Email();
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }

        /// <summary>
        /// Tests the method and returns sad if entry is unsuccessfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod6(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Email();
            //Assert
            Assert.AreEqual("Entry Unsuccessful", result);
        }

        /// <summary>
        /// Tests the method and returns happy if entry is successfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod7(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.MobileNumber();
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }

        /// <summary>
        /// Tests the method and returns sad if entry is unsuccessfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod8(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.MobileNumber();
            //Assert
            Assert.AreEqual("Entry Unsuccessful", result);
        }

        /// <summary>
        /// Tests the method and returns happy if entry is successfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod9(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Password();
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }

        /// <summary>
        /// Tests the method and returns sad if entry is unsuccessfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod10(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Password();
            //Assert
            Assert.AreEqual("Entry Unsuccessful", result);
        }

        /// <summary>
        /// Tests the method and validates Multipleemails 
        /// Test case will be passed if validation is successfull
        /// </summary>
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            UserRegister userRegister = new UserRegister();
            //Act
            var result = userRegister.MultipleEmails("abc@edu.co.in", "abc+100@gmail.com");
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }
    }
}