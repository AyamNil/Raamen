using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Factory
{
    public class RoleFactory
    {
        public static Role NewRole(int id, string name)
        {
            Role AddRole = new Role();
            AddRole.name = name;

            return AddRole;
        }
    }
}