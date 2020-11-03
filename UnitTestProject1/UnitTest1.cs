using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingLambda;

namespace UnitTestProject1
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
            Assert.AreEqual("Entry Successfull", result);
        }
        /// <summary>
        /// Tests the method and returns sad if entry is unsuccessfull.
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
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        /// <summary>
        /// Tests the method for lastname and returns happy if entry is successfull
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
            Assert.AreEqual("Entry Successfull", result);
        }
        /// <summary>
        /// Tests the method for lastname and returns sad if entry is unsuccessfull.
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
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        /// <summary>
        /// Tests the method for email and returns happy if entry is successfull
        /// </summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod5(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Email();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        /// <summary>
        /// Tests the method for email and returns sad if entry is unsuccessfull
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
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        /// <summary>
        /// Tests the method for mobileno and returns happy if entry is successfull
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
            Assert.AreEqual("Entry Successfull", result);
        }
        /// <summary>
        /// Tests the method for mobileno and returns sad if entry is unsuccessfull
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
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        /// <summary>
        /// Tests the method for password if entry is successfull it returns happy
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
            Assert.AreEqual("Entry Successfull", result);
        }
        /// <summary>
        /// Tests the method for password if entry is unsuccessfull it returns sad
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
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
    }
}
