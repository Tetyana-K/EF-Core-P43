using Microsoft.EntityFrameworkCore;
using One_To_One__Person_Passport_.Models;

namespace One_To_One__Person_Passport_.Data
{
    public class PersonDbContext: DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Passport> Passports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=EFPersonWithPassportDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
