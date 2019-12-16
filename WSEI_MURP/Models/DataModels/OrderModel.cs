using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_MURP.Models.DataModels
{
    public class OrderModel
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public long CompanyId { get; set; }
        public string Localization { get; set; }
        public string Status { get; set; }
        public bool DriverRequired { get; set; }


        [Required]
        public long CarId { get; set; }
        [Required]
        public double Price { get; set; }
        public long UserId { get; set; }

        public virtual CarModel Car { get; set; }
        public virtual CompanyModel Company { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
