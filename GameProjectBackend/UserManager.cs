using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    public class UserManager : IUserService
    {
     
        public void Add(User user)
        {
            Console.WriteLine(user.FirstName+ " eklendi");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName+ " silindi");
        }

        public void Remove(User user)
        {
            Console.WriteLine(user.FirstName + " değiştirildi");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " güncellendi");
        }
    }
}
