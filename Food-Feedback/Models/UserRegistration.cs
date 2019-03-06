using System;
using System.Collections.Generic;

namespace FoodFeedback.Models
{
    public partial class UserRegistration
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
