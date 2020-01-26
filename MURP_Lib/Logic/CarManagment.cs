using MURP_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MURP_Lib.Logic
{
    public static class CarManagment
    {
        public static List<Car> Cars;

        public static void CreateCar(string brand, string model, string registrationNumber)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(registrationNumber))
            {
                throw new ArgumentNullException();
            }

            Validators v = new Validators();

            if (v.CarRegistrationNumberValid(registrationNumber))
            {
                Car newcar = new Car(brand, model, registrationNumber);
                Cars.Add(newcar);
            }
            else
            {
                throw new FormatException();
            }
        }

        public static void CreateCar(Car car)
        {
            if (string.IsNullOrEmpty(car.Brand) || string.IsNullOrEmpty(car.Model) || string.IsNullOrEmpty(car.Registration_Number))
            {
                throw new ArgumentNullException();
            }

            Validators v = new Validators();

            if (v.CarRegistrationNumberValid(car.Registration_Number))
            {
                Cars.Add(car);
            }
            else
            {
                throw new FormatException();
            }
        }

        public static Car FindByRegistrationNumber(string RegistrationNumber)
        {
            return Cars.SingleOrDefault(c => c.Registration_Number == RegistrationNumber);
        }
    }
}
