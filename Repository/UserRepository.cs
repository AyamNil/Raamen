using Lab.Factory;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raamen.Factory;

namespace Raamen.Repository
{
    public class UserRepository
    {
        Database1Entities db = new Database1Entities();
        public User InsertUser(string Username, string Email,string gender, string password, int RoleId)
        {
            UserFactory uf = new UserFactory();
            User u = uf.newUser(Username, Email, gender, password, Convert.ToInt32(RoleId));

            db.Users.Add(u);
            db.SaveChanges();

            return u;
        }

        public void updateUser(int id,string Username, string Email, string gender, string password, int RoleId)
        {
            User upUser = db.Users.Find(id);
            upUser.Username = Username;
            upUser.Email = Email;
            upUser.Gender = gender;
            upUser.Password = password;
            upUser.Role_Id = RoleId;
            db.Users.Add(upUser);
            db.SaveChanges();
        }

        public void deleteUser(int id, string Username, string Email, string gender, string password, int RoleId)
        {
            User delUser = db.Users.Find(id);
            db.Users.Remove(delUser);
            db.SaveChanges();
        }

        public User checkUser(string username, string password)
        {
            User u = (from user in db.Users where user.Username == username && user.Password == password select user).FirstOrDefault();
            return u;
        }
    }
}