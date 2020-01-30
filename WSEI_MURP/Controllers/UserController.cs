using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSEI_MURP.Models.DataContext;
using WSEI_MURP.Models.DataModels;
using WSEI_MURP.Models.ViewModels;

namespace WSEI_MURP.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly OrderDataContext orderDB;
        private readonly CompanyDataContext companyDB;
        private readonly CarDataContext carDB;

        public UserController(OrderDataContext orderDB, CompanyDataContext companyDB, CarDataContext carDB)
        {
            this.orderDB = orderDB;
            this.companyDB = companyDB;
            this.carDB = carDB;
        }
        public IActionResult Index()
        {
            var IsCompanyMember = companyDB.Company.Where(x => x.EmailAddress == User.Identity.Name).ToArray();

            ViewBag.IsCompany = IsCompanyMember.Length > 0 ? true : false;

            if (ViewBag.IsCompany)
                return RedirectToAction("Index", "Company");
            else
            {
                var order_History = orderDB.Orders.Where(x => x.UserEmail == User.Identity.Name);

                ViewBag.UserName = User.Identity.Name;
                ViewBag.Order_History = order_History;

                return View();
            }
        }

        public IActionResult OrderSummary(string orderId)
        {
            ViewBag.Order = orderDB.Orders.SingleOrDefault(x => x.OrderID == orderId);
            ViewBag.UserEmail = User.Identity.Name;
            return View();
        }

        public IActionResult SaveOrder(string orderId)
        {
            var order = orderDB.Orders.SingleOrDefault(x => x.OrderID == orderId);

            order.Status = "IN PROGRESS";
            order.UserEmail = User.Identity.Name;

            orderDB.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ResolveAndRateOrder(string orderId)
        {
            var order = orderDB.Orders.SingleOrDefault(x => x.OrderID == orderId);

            ViewBag.Order = order;
            ViewBag.Ratings = new List<int>() { 1, 2, 3, 4, 5 };

            return View();
        }

        public IActionResult RateOrder(RateOrderViewModel orderRating)
        {
            var order = orderDB.Orders.SingleOrDefault(x => x.OrderID == orderRating.OrderID);
            var company = companyDB.Company.SingleOrDefault(x => x.EmailAddress == order.CompanyEmail);

            order.Status = "RESOLVED";
            order.UserRating = orderRating.OrderRating;

            var car = carDB.Cars.SingleOrDefault(x => x.RegistrationNumber == order.CarRegistrationNumber);
            car.Status = "FREE";

            company.CompanyRatingScore += order.UserRating;
            company.CompanyRatingAmount++;

            orderDB.SaveChanges();
            carDB.SaveChanges();
            companyDB.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}