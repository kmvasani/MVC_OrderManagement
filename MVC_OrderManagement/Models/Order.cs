using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static MVC_OrderManagement_Common.Common_OrderStatus;

namespace MVC_OrderManagement.Models
{
    public class Order
    {
        [Display(Name  = "Order Id")]
        public Guid OrderId { get; set; }


        [Display(Name = "Order Name")]
        [Required]
        public string OrderName { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }


        public OrderStatus OrderStatus { get; set; }
    }
} 