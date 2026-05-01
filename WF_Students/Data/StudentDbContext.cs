using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Students.Models;

namespace WF_Students.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } // Властивість DbSet для роботи з таблицею Студенти
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Вказуємо рядок підключення до бази даних
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EF_StudentDbP43;Trusted_Connection=True;");//;
               //.LogTo(Console.WriteLine);//, Microsoft.Extensions.Logging.LogLevel.Information); // Логування SQL-запитів у консоль
                                          // .EnableSensitiveDataLogging();// Дозволяє логувати чутливі дані (наприклад, значення параметрів) у SQL-запитах
        }
    }
}
