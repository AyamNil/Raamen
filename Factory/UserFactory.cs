using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public class UserFactory
    {
        public User newUser(string Username, string Email, string gender, string password, int Role_Id)
        {
            User addUser = new User();
            addUser.Username = Username;
            addUser.Email = Email;
            addUser.Gender = gender;
            addUser.Password = password;
            addUser.Role_Id = Role_Id;
            return addUser;
        }
    }
}