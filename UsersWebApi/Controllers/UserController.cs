using GoldtagSample.Core.Users;
using GoldtagSample.Core.Users.Interfaces;
using GoldtagSample.Domain.Users.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldtagSampleFurkan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUsersRepository users = new UsersRepository();

        [HttpGet("GetAllUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            return users.GetUsers();
        }

        [HttpGet("GetUserById/{id}")]
        public User GetOneUserById(int id)
        {
            return users.GetUserById(id); 
        }

        [HttpPost("InsertNewUser/{userName}/{userEmail}/{userPassword}")]
        public string InsertUser(String userName, String userEmail, String userPassword)
        {
            return users.InsertUser(userName, userEmail, userPassword);
        }

        [HttpPut("UpdateUserPassword/{userId}/{userEmail}/{userPassword}/{userNewPassword}")]
        public User UpdatePassword(int userId, String userName, String userEmail, String userPassword, String userNewPassword)
        {
            return users.UpdatePassword(userId, userName, userEmail, userPassword, userNewPassword);
        }

        [HttpPut("UpdateUserEmail/{userId}/{userEmail}/{userPassword}/{userNewEmail}")]
        public User UpdateEmail(int userId, String userName, String userEmail, String userPassword, String userNewEmail)
        {
            return users.UpdateEmail(userId, userName, userEmail, userPassword, userNewEmail);
        }
    }
}
