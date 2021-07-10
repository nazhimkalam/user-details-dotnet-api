using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Detials_API.Models;

namespace User_Detials_API.Data
{
    public class SqlUserRepo : IUserOperations
    {
        private readonly UserContext _context;

        public SqlUserRepo(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.id == id);
        }
    }
}
