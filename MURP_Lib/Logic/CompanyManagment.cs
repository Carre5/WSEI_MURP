using MURP_Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MURP_Lib.Logic
{
    public static class CompanyManagment
    {
        public static List<Company> Companies;

        public static Company FindByEmail(string email)
        {
            return Companies.SingleOrDefault(c => c.Email_Address == email);
        }

        public static void HandleRating(Company company, Order_Rating rating)
        {
            Company tempComp = Companies.SingleOrDefault(c => c == company);
            tempComp.Company_Rating_Amount++;
            tempComp.Company_Rating_Score += int.Parse(rating.ToString());
        }
    }
}
