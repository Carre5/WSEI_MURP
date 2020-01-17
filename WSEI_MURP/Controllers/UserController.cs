using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSEI_MURP.Models.DataContext;
using WSEI_MURP.Models.DataModels;

namespace WSEI_MURP.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly OrderDataContext orderDB;
        private readonly CompanyDataContext companyDB;


        public UserController(OrderDataContext orderDB, CompanyDataContext companyDB)
        {
            this.orderDB = orderDB;
            this.companyDB = companyDB;
        }
        public IActionResult Index()
        {
            var IsCompanyMember = companyDB.Company.Where(x => x.EmailAddress == User.Identity.Name).ToArray();

            ViewBag.IsCompany = IsCompanyMember.Length > 0 ? true : false;

            if (ViewBag.IsCompany)
                return RedirectToAction("Index", "Company");
            else
            {
                List<OrderModel> order_History = new List<OrderModel>();

                //List<OrderModel> userOrders = orderDB.Orders.Where(x => x.UserId == User.Identity.Name).ToArray();
                //return View(userOrders);

                ViewBag.UserName = User.Identity.Name;
                ViewBag.Order_History = order_History;

                return View();
            }
        }
    }
}