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
        //private readonly CompanyDataContext db;
        private readonly OrderDataContext orderDB;
        private readonly CarDataContext carDB;
        public CompanyController(CarDataContext carDB, OrderDataContext orderDB)
        {
            //this.db = db;
            this.orderDB = orderDB;
            this.carDB = carDB;

            fillData();
        }

        public IActionResult Order()
        {
            ViewBag.Orders = orderDB.Orders
                .Where(x => x.CompanyEmail == User.Identity.Name)
                .ToArray();
            return View();
        }

        public IActionResult Cars()
        {
            ViewBag.Cars = carDB.Cars
                .Where(x => x.CompanyEmail == User.Identity.Name)
                .ToArray();
            return View();
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(CarModel car)
        {
            car.CompanyEmail = User.Identity.Name;
            car.Status = "Free";
            carDB.Cars.Add(car);
            carDB.SaveChanges();

            return RedirectToAction("Cars");
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            //add registration number to car data model
            ViewBag.Cars = carDB.Cars
                .Where(x => x.CompanyEmail == User.Identity.Name)
                .ToArray();
            return RedirectToAction("Order");
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderModel order)
        {
            order.CreationDate = DateTime.Now;
            order.CompanyEmail = User.Identity.Name;
            order.Status = "New";

            orderDB.Orders.Add(order);
            orderDB.SaveChanges();
            return RedirectToAction();
        }

        public IActionResult RegisterCompany()
        {
            return View();
        }

        private void fillData()
        {
            /*
            if (carDB.Cars.ToArray().Length == 0)
            {
                var cars = new CarModel[]
                {
                new CarModel()
                {
                    Brand = "Fiat",
                    Model = "Ducato",
                    Load = 2200,
                    Category = "Dostawcze",
                    CompanyEmail = "company1@company.com"
                },
                new CarModel()
                {
                    Brand = "Fiat",
                    Model = "Doblo",
                    Load = 500,
                    Category = "Dostawcze",
                    CompanyEmail = "company1@company.com"
                },
                new CarModel()
                {
                    Brand = "Mercedes",
                    Model = "Sprinter",
                    Load = 1000,
                    Category = "Dostawcze",
                    CompanyEmail = "company2@company.com"
                },
                new CarModel()
                {
                    Brand = "Mercedes",
                    Model = "Sprinter",
                    Load = 1000,
                    Category = "Dostawcze",
                    CompanyEmail = "company2@company.com"
                },
                new CarModel()
                {
                    Brand = "Mercedes",
                    Model = "Sprinter",
                    Load = 1000,
                    Category = "Dostawcze",
                    CompanyEmail = "company3@company.com"
                },
            };

                foreach (var car in cars)
                {
                    carDB.Cars.Add(car);
                }
                carDB.SaveChanges();
            }
            */
        }
    }
}