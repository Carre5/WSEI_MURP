using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Models
{
    public class Order
    {
        public string Order_ID { get; set; }
        public Order_Status Status { get; set; }
        public Company Company { get; set; }
        public User Assigned_User { get; set; }
        public DateTime Creation_Date { get; set; }
        public Order_Rating User_Rating { get; set; }
        public Car Assigned_Car { get; set; }
    }
}
