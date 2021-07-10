using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using User_Detials_API.Data;
using User_Detials_API.Models;

namespace User_Detials_API.Controllers
{
    [Route("/api/users")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly IUserOperations _repo;

        // creating a constructor for dependency injection
        public UserAPIController(IUserOperations repo)
        {
            _repo = repo;
        }

        // GET /api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {

            return Ok(_repo.GetAllUsers());

        }

        // GET /api/users/{id}                                      
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {

            return Ok(_repo.GetUserById(id));

        }
    }
}
