using Raamen.Factory;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class RamenRepository
    {
        Database1Entities db = new Database1Entities();
        public Raman InsertRamen(string name, string broth, string price, int meatId)
        {
            RamenFactory rf = new RamenFactory();
            Raman ra = rf.newRamen(name, broth, price, Convert.ToInt32(meatId));
            db.Ramen.Add(ra);
            db.SaveChanges();

            return ra;
        }

        public void updateRamen(int id, string name, string broth, string price, int meatId)
        {
            Raman UpRamen = db.Ramen.Find(id);
            UpRamen.Name = name;
            UpRamen.Broth = broth;
            UpRamen.Price = price;
            UpRamen.MeatId = meatId;
            db.SaveChanges();
        }

        public void deleteRamen(int id, string name, string broth, string price, int meatId)
        {
            Raman DelRamen = db.Ramen.Find(id);
            db.Ramen.Remove(DelRamen);
            db.SaveChanges();
        }

        public List<Raman> getAllRamen()
        {
            return (from r in db.Ramen select r).ToList();
        }
    }
}