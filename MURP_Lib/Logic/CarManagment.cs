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
            if (Validators.CarRegistrationNumberValid(registrationNumber))
            {
                Car newcar = new Car()
                {
                    Brand = brand,
                    Model = model,
                    Registration_Number = registrationNumber
                };

                Cars.Add(newcar);
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
