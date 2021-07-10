


using System.Collections.Generic;
using User_Detials_API.Models;

namespace User_Detials_API.Data
{
    public interface IUserOperations
    {

        // Method Signature to return all the User data
        IEnumerable<User> GetAllUsers();

        // Method Signature to return a User based on the input 'id'
        User GetUserById(int id);

    }
}
