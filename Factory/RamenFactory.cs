using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class RamenFactory
    {
        public Raman newRamen(string name, string broth, string price, int meatId)
        {
            Raman addRamen = new Raman();
            addRamen.Name = name;
            addRamen.Broth = broth;
            addRamen.Price = price;
            addRamen.MeatId = meatId;
            return addRamen;
        }
    }
}