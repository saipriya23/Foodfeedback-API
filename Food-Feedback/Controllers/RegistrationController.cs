using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoodFeedback.Models;
using FoodFeedback.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food_Feedback.Controllers
{
    /// <summary>
    /// contains the methods for user registration
    /// </summary>
    [Route("api/Registration")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegisterService _registrationService;

        public RegistrationController(IRegisterService registrationService)
        {
            _registrationService = registrationService;
        }

        /// <summary>
        /// validating the model and posting the userdetails 
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
        [HttpPost]
        
        public IActionResult RegisterUser([FromBody] UserDto userDetails)
        {
            if (userDetails!=null)
            {
                if (ModelState.IsValid)
                {
                    var result = _registrationService.AddUsers(userDetails);
                    if (result == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}
