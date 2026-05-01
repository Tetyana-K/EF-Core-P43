using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities__Migrations_
{
    public class CitiesDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFCitiesDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
