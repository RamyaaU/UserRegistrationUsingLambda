using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingLambda;

namespace UnitTestProject3
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
        /// TTests the method and returns happy if entry is successfull
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
        /// <summary>
        /// Tests the method for firstname validation
        /// </summary>
        /// <param name="fname">The fname.</param>
        [TestMethod]
        [DataRow("1Ramya")]
        public void TestMethod12(string fname)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckFirstName(fname);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("First Name is Invalid !!", e.Message);
            }
        }
        /// <summary>
        /// Tests the method for lastname validation
        /// </summary>
        /// <param name="lname">The lname.</param>
        [TestMethod]
        [DataRow("2Uday")]
        public void TestMethod13(string lname)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckLastName(lname);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Last Name is Invalid !!", e.Message);
            }
        }
        /// <summary>
        /// Tests the method for email validation
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("ram100@gmail.co.in.uk")]
        public void TestMethod14(string email)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckEmail(email);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Email is Invalid !!", e.Message);
            }
        }
        /// <summary>
        /// Tests the method for validation of mobile number
        /// </summary>
        /// <param name="mobNumber">The mob number.</param>
        [TestMethod]
        [DataRow("91 95ab131bj1")]
        public void TestMethod15(string mobNumber)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckMobile(mobNumber);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Mobile number is Invalid !!", e.Message);
            }
        }
        /// <summary>
        /// Tests the method for validation of password
        /// </summary>
        /// <param name="password">The password.</param>
        [TestMethod]
        [DataRow("svfd122dd")]
        public void TestMethod16(string password)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckPassword(password);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Password is Invalid !!", e.Message);
            }
        }
    }
}
