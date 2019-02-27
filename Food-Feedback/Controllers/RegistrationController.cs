using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodFeedback.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food_Feedback.Controllers
{
    [Route("api/Registration")]
    public class RegistrationController : ControllerBase
    {
        [HttpPost]
        public IActionResult RegistrationForm([FromBody] UserRegistration userDetails)
        {
            if (ModelState.IsValid)
            {
                using (var entity = new FoodFeedbackContext())
                {
                    entity.UserRegistration.Add(userDetails);
                    entity.SaveChanges();
                    return Ok(true);
                }
            }
            return Ok(false);
        }
    }
}
