using MVC_OrderManagement.Models;
using MVC_OrderManagement_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_OrderManagement.Mapper
{
    public static class OrderMapper
    {
        public static Order Map(this MVC_OrderManagement_DataLayer.Order entities)
        {
            Enum.TryParse(entities.OrderStatus, true, out Common_OrderStatus.OrderStatus result);

            return new Order()
            {
                OrderId = entities.OrderId,
                OrderName = entities.OrderName,
                OrderDate = entities.OrderDate,
                OrderStatus = result
            };
        }
    }
}