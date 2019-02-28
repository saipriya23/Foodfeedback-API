using FoodFeedback.Models;
using FoodFeedback.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFeedback.Services
{
    public class RegisterService : IRegisterService
    {
        public bool AddUsers(UserDto userDto)
        {
            using (var entity = new FoodFeedbackContext())
            {
                var userDetails = new UserRegistration()
                {
                    EmployeeId=userDto.EmployeeId,
                    Email = userDto.Email,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Password = userDto.Password,
                    UserName = userDto.UserName
                };

                entity.UserRegistration.Add(userDetails);
                entity.SaveChanges();
                return true;
            }
        }
    }
}
