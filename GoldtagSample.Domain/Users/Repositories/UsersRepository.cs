using GoldtagSample.Core.Users;
using GoldtagSample.Core.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldtagSample.Domain.Users.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersDbContext usersDbContext;

        public UsersRepository()
        {
            usersDbContext = new UsersDbContext();
        }
        
        //Gets All Users
        IEnumerable<User> IUsersRepository.GetUsers()
        {
            return usersDbContext.Users;
        }

        //Get User By Id
        User IUsersRepository.GetUserById(int id)
        {
            var user = usersDbContext.Users.Find(id);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        //Insert New User
        string IUsersRepository.InsertUser(String userName, String userEmail, String userPassword)
        {
            UsersDbContext userDb = new UsersDbContext();

            User usr = new User();
            usr.Name = userName;
            usr.Email = userEmail;
            usr.Password = userPassword;

            userDb.Users.Add(usr);
            userDb.SaveChanges();

            return "User data is saved successfully";
        }

        //Update User Password
        public User UpdatePassword(int userId, String userName, String userEmail, String userPassword, String userNewPassword)
        {
            var user = usersDbContext.Users.Find(userId);

            if (user != null)
            {
                if (user.UserId == userId && user.Email == userEmail && user.Password == userPassword)
                {
                    usersDbContext.Users.Find(user.UserId).Password = userNewPassword;
                    usersDbContext.SaveChanges();
                    return user;
                }
                
                return null;
            }

            return user;
        }

        //Update user Email
        public User UpdateEmail(int userId, String userName, String userEmail, String userPassword, String userNewEmail)
        {

            var user = usersDbContext.Users.Find(userId);

            if (user != null)
            {
                if (user.UserId == userId && user.Email == userEmail && user.Password == userPassword)
                {
                    usersDbContext.Users.Find(user.UserId).Email = userNewEmail;
                    usersDbContext.SaveChanges();
                    return user;
                }

                return null;

            }

            return user;
        }
    }
}
