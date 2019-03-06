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
    public class TestForUserRegistration
    {
        [Fact]
        public void Should_Return_Success_When_Data_Is_valid()
        { 

            var mockRegistrationService = new Mock<IRegisterService>();
            mockRegistrationService.Setup(record => record.AddUsers(It.IsAny<UserDto>())).Returns(true);
            var userDetails = new RegistrationController(mockRegistrationService.Object);
            
            var response = userDetails.RegisterUser(new UserDto() { EmployeeId="cesit/0015",UserName="saipriya",FirstName="Priya",LastName="reddy",Email="priya.reddy@cesltd.com",Password="priya2123"});

            Assert.Equal(200, ((OkObjectResult)response).StatusCode);
       
        }
       
        [Fact]

        public void Should_Return_BadRequest_When_Data_Is_Invalid()
        {

            var mockRegistrationService = new Mock<IRegisterService>();
            mockRegistrationService.Setup(record => record.AddUsers(It.IsAny<UserDto>())).Returns(false);
            var userDetails = new RegistrationController(mockRegistrationService.Object);

            var result = userDetails.RegisterUser(new UserDto() { }); 

            Assert.Equal(400, ((BadRequestResult)result).StatusCode);
     
        }

    }
}
