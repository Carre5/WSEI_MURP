using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSEI_MURP.Controllers;
using WSEI_MURP.Models.Account;
using WSEI_MURP.Models.DataContext;
using WSEI_MURP.Models.DataModels;
using WSEI_MURP.Models.ViewModels;

namespace MoveURPack.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly OrderDataContext orderDB;
        private readonly CarDataContext carDB;
        private readonly CompanyDataContext companyDB;
        public CompanyController(CarDataContext carDB, OrderDataContext orderDB, CompanyDataContext companyDB)
        {
            this.orderDB = orderDB;
            this.carDB = carDB;
            this.companyDB = companyDB;
        }

        public IActionResult Index()
        {
            var nameResult = companyDB.Company.FirstOrDefault(x => x.EmailAddress == User.Identity.Name);

            if (nameResult != null)
            {
                ViewBag.Company_Name = nameResult.CompanyName;
                ViewBag.Company_Feadback_Total_Score = nameResult.CompanyRatingScore;
                ViewBag.Company_Feedback_Amount = nameResult.CompanyRatingAmount;
            }
            else
            {
                ViewBag.Company_Name = User.Identity.Name;
                ViewBag.Company_Feadback_Total_Score = -1;
                ViewBag.Company_Feedback_Amount = -1;
            }

            ViewBag.Orders = orderDB.Orders
                .Where(x => x.CompanyEmail == User.Identity.Name)
                .ToArray();

            return View();
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
            car.Status = "FREE";
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
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderModel order)
        {
            order.CreationDate = DateTime.Now;
            order.CompanyEmail = User.Identity.Name;
            order.Status = "NEW";

            int orderAmount = orderDB.Orders.Where(x => x.CompanyEmail == User.Identity.Name).ToArray().Length;
            orderAmount++;

            order.OrderID = DateTime.Now.ToString("yyyymmdd") + orderAmount.ToString();
            order.UserRating = 0;

            orderDB.Orders.Add(order);
            orderDB.SaveChanges();
            return RedirectToAction("Order");
        }

        [HttpGet]
        public IActionResult PublishOrder(string orderId)
        {
            var result = orderDB.Orders.SingleOrDefault(x => x.OrderID == orderId);

            if (result != null)
            {
                result.Status = "READY";
                orderDB.SaveChanges();

                /*var carResult = carDB.Cars.SingleOrDefault(x => x.RegistrationNumber == result.CarId);

                if (carResult != null)
                {
                    carResult.Status = "BUSY"
                    carDB.SaveChanges();
                }
                */
            }

            return RedirectToAction("Order");
        }

        [HttpGet]
        public IActionResult UnpublishOrder(string orderId)
        {
            var result = orderDB.Orders.SingleOrDefault(x => x.OrderID == orderId);

            if (result != null)
            {
                result.Status = "NEW";
                orderDB.SaveChanges();

                /*var carResult = carDB.Cars.SingleOrDefault(x => x.RegistrationNumber == result.CarId);

                if (carResult != null)
                {
                    carResult.Status = "FREE"
                    carDB.SaveChanges();
                }
                */
            }

            return RedirectToAction("Order");
        }

        [HttpGet]
        public IActionResult RegisterCompany()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterCompany(CompanyRegisterViewModel company)
        {
            var uniqueResult = companyDB.Company.FirstOrDefault(x => x.EmailAddress == company.Email);

            if (uniqueResult != null)
            {
                companyDB.Company.Add(new CompanyModel()
                {
                    CompanyName = company.Name,
                    CompanyAddress = company.Address,
                    EmailAddress = User.Identity.Name,
                    TaxNumber = company.TaxNumber,
                    CompanyRatingScore = 0,
                    CompanyRatingAmount = 0
                });

                companyDB.SaveChanges();

                return View("Index");
            }
            else
            {
                ModelState.AddModelError("", "Company with the same email already exists. Please change email of organization!");
                return View();
            }
            
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