using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class MeatRepository
    {
        Database1Entities db = new Database1Entities();
        public List<Meat> getMeat()
        {
            List<Meat> meat = (from r in db.Meats select r).ToList();
            return meat;
        }
    }
}