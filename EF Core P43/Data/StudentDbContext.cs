using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_P43.Models;
using Microsoft.EntityFrameworkCore;

//DbContext = сесія з базою, яка дозволяє виконувати операції з базою даних, такі як створення, читання, оновлення та видалення даних.
//Він також відповідає за відстеження змін у сутностях та керування транзакціями.

//Клас контексту бази даних зазвичай успадковується від DbContext і містить властивості DbSet для кожної сутності,
//яку  хочемо зберігати в базі даних.

//DbSet = таблиця, яка дозволяє виконувати операції з даними для конкретної сутності.
//Вона надає методи для додавання, видалення та оновлення записів у базі даних, а також для виконання запитів до цієї таблиці.
//Кожна властивість DbSet у класі контексту бази даних відповідає певній сутності, яку ми хочемо зберігати в базі даних.

namespace EF_Core_P43.Data
{
    // клас контексту бази даних для роботи з сутністю Студент
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } // Властивість DbSet для роботи з таблицею Студенти

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Вказуємо рядок підключення до бази даних
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EF_StudentDbP43;Trusted_Connection=True;")//;
                //.LogTo(Console.WriteLine)//, Microsoft.Extensions.Logging.LogLevel.Information)//; // Логування SQL-запитів у консоль
                  //                       .EnableSensitiveDataLogging();// Дозволяє логувати чутливі дані (наприклад, значення параметрів) у SQL-запитах
        }
    }
}
