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

        public Company(string Name, string OfficeAddress, string EmailAddress, string TaxIdentificationNumber)
        {
            this.Name = Name;
            this.Office_Address = OfficeAddress;
            this.Email_Address = EmailAddress;
            this.Tax_Identification_Number = TaxIdentificationNumber;
            Id = 0;
            Company_Rating_Amount = 0;
            Company_Rating_Score = 0;
        }
    }
}
