using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSEI_MURP.Models;
using WSEI_MURP.Models.DataContext;
using WSEI_MURP.Models.DataModels;

namespace WSEI_MURP.Controllers
{
    public class HomeController : Controller
    {

        private readonly OrderDataContext orderDB;

        public HomeController(OrderDataContext orderDB)
        {
            this.orderDB = orderDB;
        }

        public IActionResult Index()
        {
            //TODO: show all orders that should be visible ordered by date?

            var result = orderDB.Orders.Where(x => x.Status == "READY").ToArray();
            if (result != null)
            {
                ViewBag.Orders = result;
            }

            return View();
        }

        [HttpGet]
        public IActionResult Order(string id)
        {
            var result = orderDB.Orders.SingleOrDefault(x => x.OrderID == id);
            if (result != null)
            {
                ViewBag.Order = result;
            }
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
