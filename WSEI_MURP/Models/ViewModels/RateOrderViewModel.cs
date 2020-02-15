using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_MURP.Models.DataModels;

namespace WSEI_MURP.Models.ViewModels
{
    public class RateOrderViewModel
    {
        public string OrderID { get; set; }
        public string CompanyEmail { get; set; }
        public string Status { get; set; }
        public double CompanyRating { get; set; }
        public int OrderRating { get; set; }
    }
}
