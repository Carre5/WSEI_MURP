using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_MURP.Models.DataModels
{
    public class CarModel
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Load { get; set; }
        public string Category { get; set; }
    }
}
