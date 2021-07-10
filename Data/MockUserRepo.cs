using System;
using System.Collections.Generic;

using User_Detials_API.Models;

namespace User_Detials_API.Data
{
    public class MockUserRepo : IUserOperations
    {
        public IEnumerable<User> GetAllUsers()
        {
            // we are justing returning a list of random users hardcoded for now
            return new List<User> {
                new User { id = 0, name = "Nazhim", age = 19  },
                new User { id = 1, name = "Hashim", age = 14  },
                new User { id = 2, name = "Kalam", age = 30  }
            };
        }

        public User GetUserById(int id)
        {
            // we are just returning a single hardcoded user
            return new User { id = 0, name = "Nazhim", age = 19 };
        }
    }
}
