using System;
using System.Collections.Generic;
using System.Text;

namespace MURP_Lib.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Office_Address { get; set; }
        public string Email_Address { get; set; }
        public string Tax_Identification_Number { get; set; }
        public int Company_Rating_Score { get; set; }
        public int Company_Rating_Amount { get; set; }
    }
}
