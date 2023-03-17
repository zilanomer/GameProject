using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    public class UserValidateManager : IUserValidation
    {
       
        bool IUserValidation.Validate(User user)
        {
            if(user.FirstName == "Zilan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
