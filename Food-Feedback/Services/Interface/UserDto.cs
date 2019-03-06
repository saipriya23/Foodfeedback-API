using System.ComponentModel.DataAnnotations;

namespace FoodFeedback.Services.Interface
{
    /// <summary>
    /// contains properties for user registration
    /// </summary>
    public class UserDto
    {
        [Required]
        [MinLength(10)]
        public string EmployeeId { get; set; }
        [Required,MaxLength(100),MinLength(5)]
        public string FirstName { get; set; }
        [Required,MaxLength(100),MinLength(5)]
        public string LastName { get; set; }
        [Required,MaxLength(100),MinLength(5)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required,MinLength(6)]
        public string Password { get; set; }
    }
}