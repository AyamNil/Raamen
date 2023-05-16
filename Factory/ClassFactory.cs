using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class ClassFactory
    {
        public static Detail newDetail(int HeaderId,int RamenId, int quantity)
        {
            Detail addDetail = new Detail();
            addDetail.Quantity = quantity;

            return addDetail;
        }
    }
}