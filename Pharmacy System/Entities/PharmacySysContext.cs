using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_System.Entities
{
    internal class PharmacySysContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PharmacySys;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Emloyee> Emloyees { get; set; }
        public virtual DbSet<Company> Companies{ get; set; }


    }
}
