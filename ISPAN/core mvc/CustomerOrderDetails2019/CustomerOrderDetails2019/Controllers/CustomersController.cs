using CustomerOrderDetails2019.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrderDetails2019.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            NorthwindContext dc = new NorthwindContext();
            ViewBag.CustomerID = new SelectList(dc.Customers, "CustomerId", "CompanyName");
            return View();
        }

        public async Task<IActionResult> Orders(string id)
        {
            NorthwindContext dc = new NorthwindContext();
            Customers c = await dc.Customers.FindAsync(id);

            //不自動載入導覽屬性內容
            //return PartialView("_OrdersPartial", dc.Orders.Where(o=>o.CustomerId==id));
            //自動載入導覽屬性內容
            return PartialView("_OrdersPartial", c.Orders);
        }
    }
}
