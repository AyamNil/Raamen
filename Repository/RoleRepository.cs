using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class RoleRepository
    {
        Database1Entities db = new Database1Entities();
        public List<Role> getRole()
        {
            List<Role> roles = (from r in db.Roles select r).ToList();
            return roles;
        }

        public String getRoleName(int id)
        {
           return (from role in db.Roles where role.Id == id select role.name).FirstOrDefault();
        }
    }
}