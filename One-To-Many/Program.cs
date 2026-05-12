// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using One_To_Many.Data;
using One_To_Many.Models;

Console.WriteLine("One-To-Many relation demo");
using var db = new MenuDbContext();

DBSeeder(); // заповнюємо базу даних початковими даними (якщо вона ще порожня)

//AddMenu("Drinks"); // додаємо нове меню без страв
//AddDishToMenu("Drinks", "Coca-Cola", "Refreshing soft drink", 30.0m); // додаємо страву до меню "Drinks"
//AddDishToMenu("Drinks", "Spike-Water", "Refreshing soft drink", 15.0m); // додаємо страву до меню "Drinks"
AddDishToMenu("Drinks", "Orange juice", "Orange juice with pulp", 45.0m); // додаємо страву до меню "Drinks"
UpdateDishPrice("Coca-Cola", 35.0m); // оновлюємо ціну страви "Coca-Cola"
PrintMenusWithDishes();


void PrintMenusWithDishes()
{
    var menus = db.Menus.Include(m => m.Dishes).ToList();
    foreach (var menu in menus)
    {
        Console.WriteLine($"Menu: {menu.Name}");
        foreach (var dish in menu.Dishes)
        {
            Console.WriteLine($"\tDish: {dish.Name}, Price: {dish.Price}");
        }
    }
}
void DBSeeder()
{
    if (db.Menus.Any())
    {
        return; // База даних вже містить дані, не потрібно додавати початкові дані
    }

    var hotMenu = new Menu
    {
        Name = "Hot dishes",
        Dishes = new List<Dish>
            {
                new Dish { Name = "Borsch", Description = "Traditional Ukrainian soup", Price = 70.0m },
                new Dish { Name = "Varenyky", Description = "Dumplings with potatoes", Price = 90.0m },
                new Dish { Name = "Chicken Kiev", Description = "Breaded chicken with garlic butter", Price = 120.0m }
            }
    };

    var saladMenu = new Menu
    {
        Name = "Salads",
        Dishes = new List<Dish>
            {
                new Dish { Name = "Olivier", Description = "Russian salad with vegetables and meat", Price = 50.0m },
                new Dish { Name = "Caesar", Description = "Salad with chicken and croutons", Price = 80.0m },
                new Dish { Name = "Greek", Description = "Salad with feta cheese and olives", Price = 60.0m }
            }
    };

    var desertMenu = new Menu
    {
        Name = "Desserts",
        Dishes = new List<Dish>
            {
                new Dish { Name = "Cheesecake", Description = "Creamy cheesecake with berries", Price = 100.0m },
                new Dish { Name = "Apple Pie", Description = "Homemade apple pie with ice cream", Price = 80.0m },
                new Dish { Name = "Chocolate Mousse", Description = "Rich chocolate mousse", Price = 90.0m }
            }
    };

    db.Menus.Add(hotMenu);
    db.Menus.Add(saladMenu);
    db.Menus.Add(desertMenu);

    db.SaveChanges();
}

void ClearDB()
{
    db.Menus.RemoveRange(db.Menus);
    db.Dishes.RemoveRange(db.Dishes);
    db.SaveChanges();
}

void AddMenu(string name)
{
    var menu = new Menu
    {
        Name = name,
       
    };
    db.Menus.Add(menu);
    db.SaveChanges();
}

void AddDishToMenu(string menuName, string dishName, string description, decimal price)
{
    //var menu = db.Menus.FirstOrDefault(x=> x.Name ==menuName);
    //if (menu == null)
    //{
    //    Console.WriteLine($"Add dish to menu ::: menu '{menuName}' not found.");
    //    return;
    //}
    
    // var dish = new Dish
    // {
    //     Name = dishName,
    //     Description = description,
    //     Price = price,
    //     MenuId = menu.Id
    // };
    // db.Dishes.Add(dish);

    var menu = db.Menus.Include(m => m.Dishes) // завантажуємо меню разом з його стравами, щоб мати доступ до навігаційної властивості Dishes
        .FirstOrDefault(x => x.Name == menuName);
    if (menu == null)
    {
        Console.WriteLine($"Add dish to menu ::: menu '{menuName}' not found.");
        return;
    }
    var dish = new Dish
    {
        Name = dishName,
        Description = description,
        Price = price,
       // Menu = menu // встановлюємо навігаційну властивість, EF Core автоматично встановить MenuId
    };
    //db.Dishes.Add(dish);
    menu.Dishes.Add(dish); // додаємо страву до колекції страв меню, EF Core автоматично встановить MenuId
    db.SaveChanges();
}

void UpdateDishPrice(string dishName, decimal newPrice)
{
    var dish = db.Dishes.FirstOrDefault(x => x.Name == dishName);
    if (dish == null)
    {
        Console.WriteLine($"Update dish price ::: dish '{dishName}' not found.");
        return;
    }
    dish.Price = newPrice;
    db.SaveChanges();
}
// dotnet ef  migrations add InitialCreate  - створюємо міграцію для створення бази даних на основі наших моделей
// dotnet ef database update - застосовуємо міграцію та створюємо базу даних