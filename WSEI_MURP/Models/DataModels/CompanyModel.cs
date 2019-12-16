using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_MURP.Models.DataModels
{
    public class CompanyModel
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public string TaxNumber { get; set; }
    }
}
