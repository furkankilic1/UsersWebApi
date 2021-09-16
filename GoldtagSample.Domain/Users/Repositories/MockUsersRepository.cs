using GoldtagSample.Core.Users;
using GoldtagSample.Core.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoldtagSample.Domain.Users.Repositories
{
    public class MockUsersRepository : IUsersRepository
    {
        List<User> users = new List<User>
        {
            new User{UserId=1, Name="Jack Black", Email="jackblack@gmail.com", Password="Vadodara" },
            new User{UserId=2, Name="Rocky Balboa", Email="rockybalboa@gmail.com", Password="Vadodara" },
            new User{UserId=3, Name="George Bush", Email="georgebush@gmail.com", Password="Vadodara" },
        };

        IEnumerable<User> IUsersRepository.GetUsers()
        {
            return users;
        }

        User IUsersRepository.GetUserById(int id)
        {
            return users.Find(x => x.UserId == id); 
        }

        string IUsersRepository.InsertUser(string userName, string userMail, string userPassw)
        {
            throw new NotImplementedException();
        }

        User IUsersRepository.UpdatePassword(int userId, string userName, string userEmail, string userPassword, string userNewPassword)
        {
            throw new NotImplementedException();
        }

        User IUsersRepository.UpdateEmail(int userId, string userName, string userEmail, string userPassword, string userNewEmail)
        {
            throw new NotImplementedException();
        }
    }
}
