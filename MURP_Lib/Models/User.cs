using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Models
{
    public class User
    {
        public long Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public string Home_Address { get; set; }
    }
}
