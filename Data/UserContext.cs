using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Detials_API.Models;

namespace User_Detials_API.Data
{
    public class UserContext  :DbContext
    {
        public UserContext(DbContextOptions<UserContext> opt): base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
