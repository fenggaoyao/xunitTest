using System;
using System.Collections.Generic;
using System.Text;

namespace xunitdemo
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public interface IUserRepository
    {
        bool Add(User user);
    }

    public class UserManager
    {
        private IUserRepository userRepository;
        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool CreateNewUser(User user)
        {
            if (user.Age < 0 || string.IsNullOrEmpty(user.Name))
            {
                throw new FormatException("hello error");
            }
            else
            {
                return this.userRepository.Add(user);
            }
        }
    }

    
}
