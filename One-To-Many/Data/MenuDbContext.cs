using Microsoft.EntityFrameworkCore;
using One_To_Many.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_To_Many.Data
{
    public   class MenuDbContext: DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQL Server LocalDB
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EF_MenuDb_P43;Trusted_Connection=True;");
        }
    }
}
