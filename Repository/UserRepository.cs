using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class UserRepository
    {
        Database1Entities db = new Database1Entities();
        public void InsertUser(string Username, string Email,string gender, string password, int RoleId)
        {
            User inUser = new User();
            inUser.Username = Username;
            inUser.Email = Email;
            inUser.Gender = gender;
            inUser.Password = password;
            inUser.Role_Id = RoleId;

            db.Users.Add(inUser);
            db.SaveChanges();
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