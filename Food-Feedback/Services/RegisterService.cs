using FoodFeedback.Models;
using FoodFeedback.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFeedback.Services
{
    /// <summary>
    /// contains the method to save the userdetails in database 
    /// </summary>
    public class RegisterService : IRegisterService
    {
        /// <summary>
        /// saves the user details in database
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public bool AddUsers(UserDto userDto)
        {
            try
            {
                using (var entity = new FoodFeedbackContext())
                {
                    var userDetails = new UserRegistration()
                    {
                        EmployeeId = userDto.EmployeeId,
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
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
