using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    public class UserManager : IUserService
    {
        //UserValidation ı kullanabilmek için burda soyut bir const oluştururuz.
        IUserValidation _userValidation;
        public UserManager(IUserValidation userValidation)   //UserManager a bir bağımlılığı var UserManager içeriisnde bir doğrulama servisi kullanılacak.
        {
            _userValidation = userValidation;
        }

        public void Add(User user)
        {
            if (_userValidation.Validate(user))
            {
                Console.WriteLine(user.FirstName + " eklendi");
            }

            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Başarısız.");
            }
            
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " silindi");
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
