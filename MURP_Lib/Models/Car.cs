using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Car_Status Status { get; set; }
        public string Registration_Number { get; set; }

        public Car(string brand, string model, string registrationumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Registration_Number = registrationumber;
            this.Status = Car_Status.FREE;
        }
    }
}
