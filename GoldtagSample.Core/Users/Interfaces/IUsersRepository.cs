using System;
using System.Collections.Generic;
using System.Text;

namespace GoldtagSample.Core.Users.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetUsers();

        User GetUserById(int id);

        string InsertUser(String userName, String userMail, String userPassw);

        User UpdatePassword(int userId, String userName, String userEmail, String userPassword, String userNewPassword);

        User UpdateEmail(int userId, String userName, String userEmail, String userPassword, String userNewEmail);

    }
}
