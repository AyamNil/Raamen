using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Lab.Factory
{
    public class HeaderFactory
    {
        public static Header_Table newHeader(int id, int StaffId, DateTime Date, int customerID)
        {
            Header_Table addHeader = new Header_Table();
            addHeader.CustomerId = customerID;
            addHeader.Date = Date;
            addHeader.StaffId = StaffId;

            return addHeader;
        }
    }
}