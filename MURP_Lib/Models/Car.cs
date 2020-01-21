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
    }
}
