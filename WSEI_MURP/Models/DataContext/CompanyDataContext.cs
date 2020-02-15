using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_MURP.Models.DataModels;

namespace WSEI_MURP.Models.DataContext
{
    public class CompanyDataContext : DbContext
    {
        public DbSet<CompanyModel> Company { get; set; }
        public CompanyDataContext(DbContextOptions<CompanyDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
