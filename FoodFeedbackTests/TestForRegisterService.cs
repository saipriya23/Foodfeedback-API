using Food_Feedback.Controllers;
using FoodFeedback.Models;
using FoodFeedback.Services.Interface;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FoodFeedbackTests
{
  public class TestForRegisterService
    {

        [Fact]
        public void Test_For_Valid_EmployeeId_Field()
        { 
            var details = new UserRegistration();
            var result = (details.EmployeeId = "cesit/0315");
            Assert.Equal("cesit/0315", result);
        }

        [Fact]
        public void Test_For_Valid_FirstName_Field()
        {
            var details = new UserRegistration();
            var result = (details.FirstName = "priya");
            Assert.Equal("priya", result);
        }

        [Fact]
        public void Test_For_Valid_LastName_Field()
        {
            var details = new UserRegistration();
            var result = (details.LastName = "reddy");
            Assert.Equal("reddy", result);
        }

        [Fact]
        public void Test_For_Valid_UserName_Field()
        {
            var details = new UserRegistration();
            var result = (details.UserName = "priya");
            Assert.Equal("priya", result);
        }

        [Fact]
        public void Test_For_Valid_Email_Field()
        {
         
            var details = new UserRegistration();
            var result = (details.Email = "priya.reddy@cesltd.com");
            Assert.Equal("priya.reddy@cesltd.com", result);
        }

        [Fact]
        public void Test_For_Valid_Password_Field()
        {

            var details = new UserRegistration();
            var result = (details.Password = "priya@123");
            Assert.Equal("priya@123", result);
        }
    }
}
