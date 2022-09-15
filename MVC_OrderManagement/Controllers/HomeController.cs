using MVC_OrderManagement.Mapper;
using MVC_OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_OrderManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            Order order = new Order();
            if (!string.IsNullOrEmpty(id))
            {
                MVC_OrderManagement_DataLayer.Order ord = new MVC_OrderManagement_DataLayer.Order();
                
                //var data = ord.GetOrder(id);

                //order = data.Map(); //Converting entities to DTO,
                //Simplifies above commented two lines with the below line

                order = ord.GetOrder(id).Map();

                var temp = ord.GetOrders();    //Without Stored Procedure(Using Ado.Net Query)

                var tempDTO = temp.Select(a => a.Map()); //Using Mathod Extention
            }


            //Order order = new Order()
            //{
            //    OrderId = Guid.NewGuid(),
            //    OrderName = "Watch",
            //    OrderDate = DateTime.Now,
            //    OrderStatus = ""
            //};

            //ViewBag.Kishu = "Hello welcome to this page";
            return View(order);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}