using Food_Feedback.Controllers;
using FoodFeedback.Models;
using FoodFeedback.Services.Interface;
using Moq;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FoodFeedbackTests
{
    public class UserRegistration
    {
        [Fact]
        public void TestForSuccess()
        {
            //Arrange
            var mockRegistrationService = new Mock<IRegisterService>();

            mockRegistrationService.Setup(record => record.AddUsers(It.IsAny<UserDto>())).Returns(true);
            var userDetails = new RegistrationController(mockRegistrationService.Object);

            //ACt
            var response = userDetails.RegistrationForm(new UserDto() { EmployeeId="123",UserName="saipriya",FirstName="Priya",LastName="reddy",Email="priya.reddy@cesltd.com",Password="priya2123"});

            //Assert
            Assert.Equal(200, ((OkObjectResult)response).StatusCode);
       
        }
       
        [Fact]

        public void TestForBadRequest()
        {
            var mockRegistrationService = new Mock<IRegisterService>();
            var userDetails = new RegistrationController(mockRegistrationService.Object);
            var test = new UserDto();
           
            var result = userDetails.RegistrationForm(new UserDto());
            //Assert.Equal(401, ((OkObjectResult)result).StatusCode);
     
            Assert.IsType<BadRequestObjectResult>(result);
        }

    }
}
