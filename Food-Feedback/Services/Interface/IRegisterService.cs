using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFeedback.Services.Interface
{
    public interface IRegisterService
    {
        bool AddUsers(UserDto userDto); 
    }
}
