using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_MURP.Models.ViewModels
{
    public class CompanyRegisterViewModel
    {
        [Required]
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Company Address")]
        public string Address { get; set; }
        public string Email { get; set; }
        [Required]
        [MinLength(11), MaxLength(11)]
        public string TaxNumber { get; set; }
    }
}
