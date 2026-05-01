using ConsoleApp_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Test.Data
{
    internal class GameDbContext :DbContext
    {
            public DbSet<Game> Games { get; set; }
    
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=GameDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
