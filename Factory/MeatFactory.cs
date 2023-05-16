using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class MeatFactory
    {
        public static Meat newMeat(int Id, string name)
        {
            Meat addMeat = new Meat();
            addMeat.Name = name;

            return addMeat;
        }
    }
}