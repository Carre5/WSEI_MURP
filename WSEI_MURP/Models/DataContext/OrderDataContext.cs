using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_MURP.Models.DataModels;

namespace WSEI_MURP.Models.DataContext
{
    public class OrderDataContext : DbContext
    {
        public DbSet<OrderModel> Orders { get; set; }

        public OrderDataContext(DbContextOptions<OrderDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
