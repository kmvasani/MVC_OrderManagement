using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_OrderManagement_Common
{
    public class Common_OrderStatus
    {
        public enum OrderStatus
        {
            Pending,
            Approved,
            Active,
            Ordered,
            Intransit,
            Delivered
        }
    }
}