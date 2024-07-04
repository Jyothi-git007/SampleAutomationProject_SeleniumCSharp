using APITests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APIAutomationTest
{
    [TestClass]
    public class APILevelTests
    {
        // API Test1: Get the User list
        [TestMethod]
        public void GetUsersTest()
        {
            var api = new TestSteps();
            var response = api.GetUsers();
            Assert.AreEqual(2, response.page);
        }

        // API Test2: Create a new user
        [TestMethod]
        public void CreateNewUserTest()
        {
            string payload = @"{ 
                                ""name"": ""morpheus"",
                                ""job"": ""leader""
                             }";
            var api = new TestSteps();
            var response = api.CreateNewUser(payload);
            Assert.AreEqual("morpheus", response.name);
        }

        // API Test3: Update existing user
        [TestMethod]
        public void UpdateUserTest()
        {
            string payload = @"{ 
                                ""name"": ""morpheus"",
                                ""job"": ""zion resident""
                             }";
            var api = new TestSteps();
            var response = api.UpdateUser(payload);
            Assert.AreEqual("zion resident", response.job);
        }
    }
}
