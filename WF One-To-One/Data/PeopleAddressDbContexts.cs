using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_One_To_One.Models;

namespace WF_One_To_One.Data
{
    public class PeopleAddressDbContexts :DbContext
    {
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFPeopleAddressDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
