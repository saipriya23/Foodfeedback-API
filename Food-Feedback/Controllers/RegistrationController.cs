using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodFeedback.Models;
using FoodFeedback.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food_Feedback.Controllers
{
    [Route("api/Registration")]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegisterService _registrationService;

        public RegistrationController(IRegisterService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost]
        public IActionResult RegistrationForm([FromBody] UserDto userDetails)
        {

            var result = _registrationService.AddUsers(userDetails);
            if (result == true)
            {
                return Ok(result); // success 200
            }
            return BadRequest(); // 400 bad request

        }
    }
}
