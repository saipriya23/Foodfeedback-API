using System.ComponentModel.DataAnnotations;

namespace FoodFeedback.Services.Interface
{
    public class UserDto
    {
        [Required, MinLength(3)]
        public string EmployeeId { get; set; }
        [Required,MinLength(6)]
        public string FirstName { get; set; }
        [Required,MinLength(6)]
        public string LastName { get; set; }
        [Required,MinLength(10)]
        public string UserName { get; set; }
        [Required,MaxLength(100)]
        public string Email { get; set; }
        [Required,MinLength(6)]
        public string Password { get; set; }
    }
}