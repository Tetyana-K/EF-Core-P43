using FlientApi_Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlientApi_Demo
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFProductOneTableDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>() // Налаштовуємо сутність Product
                .ToTable("ShopProducts") // Вказуємо назву таблиці в базі даних
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired() // Вказуємо, що поле Name є обов'язковим
                .HasMaxLength(100); // Вказуємо максимальну довжину для поля Name

            modelBuilder.Entity<Product>()
               .Property(p => p.Price)
               .HasColumnType("decimal(18,2)"); // Вказуємо тип колонки для поля Price, щоб зберігати точні значення для цін

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Name)
                .IsUnique(); // Створюємо унікальний індекс на поле Name, щоб забезпечити унікальність назв продуктів

            modelBuilder.Entity<Product>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()"); // Вказуємо значення за замовчуванням для поля CreatedAt

            modelBuilder.Entity<Product>()
                .Ignore(p => p.IsOnSale); // Ігноруємо поле IsOnSale, щоб воно не зберігалося в базі даних

            // можна також це записати через лямбда-вирази, але це менш читабельно:
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.ToTable("ShopProducts");
            //    entity.HasKey(p => p.Id);
            //    entity.Property(p => p.Name)
            //        .IsRequired()
            //        .HasMaxLength(100);
            //    entity.Property(p => p.Price)
            //        .HasColumnType("decimal(18,2)");

            //    entity.Property(p => p.Description)
            //        .HasMaxLength(500);
            //});

        }
    }
}
/*
 * Fluent API (вільний/текучий API) — це стиль програмування в C#, за якого методи послідовно об'єднуються в ланцюжки. 
 * Це досягається тим, що кожен метод повертає об'єкт контексту або поточний об'єкт, 
 * завдяки чому код читається природно, як звичайне речення англійською мовою, і виглядає дуже чисто.

    Де це використовується?
    1) Entity Framework Core (EF Core): Це найпопулярніше застосування Fluent API,
    використовується для конфігурації моделей баз даних (зв'язків, обмежень, первинних ключів). 
    Конфігурація відбувається всередині методу OnModelCreating.
    
    2) Валідація (наприклад, FluentValidation): Дозволяє легко створювати правила перевірки для об'єктів.
    
    3) Побудова об'єктів ( патерн Builder): Дозволяє конфігурувати складні об'єкти крок за кроком.
  */
/*Fluent API — це спосіб сказати EF Core:
    як називається таблиця
    які поля обов’язкові
    яка максимальна довжина
    який тип колонки
    які індекси створити
    які значення за замовчуванням
    які поля не зберігати
    про те, як пов’язані сутності між собою
*/