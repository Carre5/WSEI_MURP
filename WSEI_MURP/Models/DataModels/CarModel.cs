using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_MURP.Models.DataModels
{
    public class CarModel
    {
        public long Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Load { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public string Category { get; set; }
        public string CompanyEmail { get; set; }
        public string Status { get; set; }

        public string ShortDescription { get; set; }
    }
}
