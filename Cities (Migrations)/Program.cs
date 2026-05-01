// See https://aka.ms/new-console-template for more information
using Cities__Migrations_;

Console.WriteLine("___EF Core with Cities______");
using var db = new CitiesDbContext();

//City city = new City()
//{
//    Name = "Kyiv",
//    Population = 3_015_780
//};

City city2 = new City()
{
    Name = "Lviv",
    Population = 721_301
};
db.Cities.Add(city2);
db.SaveChanges();

foreach (var c in db.Cities)
{
    Console.WriteLine($"{c.Name} has population of {c.Population}");
}


/* EF Core міграції (migrations) — це механізм, який дозволяє керувати змінами структури бази даних через код.
Коли ми змінюємо свої моделі (класи), наприклад додаємо нову властивість, то EF Core сам генерує SQL,
щоб оновити базу під ці зміни.

Без міграцій:
    вручну писати SQL
    слідкувати за версіями БД
    легко наробити помилок

З міграціями:
    структура БД відповідатиме коду
    зміни відслідковуються
    можна міграцію відкотити назад
___________________________________________________________ 
Коли створили модель + контекст, то можна створити міграцію:
    dotnet ef migrations add InitialCreate
Ця команда створить папку Migrations з файлами, які описують зміни в БД.
    20260429xxxxxx_InitialCreate.cs — описує зміни (створення таблиці)
    CitiesDbContextModelSnapshot.cs — зберігає поточний стан моделі для порівняння з майбутніми змінами

Потім, щоб застосувати ці зміни до бази даних, виконуємо:
    dotnet ef database update

Після цього команда створить базу даних (якщо її ще немає) і застосує всі міграції, які ще не були застосовані.
У нашому випадку вона створить таблицю Cities з полями Id, Name та Population, тобто виконає команду
CREATE TABLE Cities (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(MAX) NOT NULL,
    Population INT NOT NULL
______________________________________________
Потрібна нова міграція, якщо 
    додаємо нове поле (н-д  string Country {get;set;})
    змінюємо тип даних (н-д int Population -> long Population)
    видаляємо поле (н-д видаляємо Population)
    змінюємо назву поля (н-д Name -> CityName)
    додаємо/видаляємо таблицю
    змінюємо зв’язки (Foreign Key)



 */