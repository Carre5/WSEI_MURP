using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSEI_MURP.Models.DataContext;
using WSEI_MURP.Models.DataModels;

namespace MoveURPack.Controllers
{
    public class CarController : Controller
    {
        private readonly CarDataContext db;
        public CarController(CarDataContext db)
        {
            this.db = db;
        }

        public IActionResult AddCar()
        {
            return View();
        }
        public IActionResult AddCarToDB(CarModel Car)
        {
            db.Cars.Add(Car);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}