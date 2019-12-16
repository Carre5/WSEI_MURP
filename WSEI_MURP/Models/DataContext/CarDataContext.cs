using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_MURP.Models.DataModels;

namespace WSEI_MURP.Models.DataContext
{
    public class CarDataContext : DbContext
    {
        public DbSet<CarModel> Cars { get; set; }
        public CarDataContext(DbContextOptions<CarDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
