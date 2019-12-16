using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSEI_MURP.Models.DataContext;
using WSEI_MURP.Models.DataModels;

namespace MoveURPack.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly CompanyDataContext db;
        private readonly OrderDataContext orderDB;
        public CompanyController(CompanyDataContext db, OrderDataContext orderDB)
        {
            this.db = db;
            this.orderDB = orderDB;
        }

        public IActionResult Order()
        {
            var orders = orderDB.Orders.ToArray();
            return View(orders);
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        public IActionResult RegisterCompany()
        {
            return View();
        }
        public IActionResult SaveCompanyToDB(CompanyModel Company)
        {
            if (Company.RepeatedPassword == Company.Password)
            {
                db.Company.Add(Company);
                db.SaveChanges();
            }
            else
            {
                throw new NotImplementedException();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}