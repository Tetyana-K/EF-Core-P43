// See https://aka.ms/new-console-template for more information
using ConsoleApp_Test.Data;
using ConsoleApp_Test.Models;

Console.WriteLine("Hello, World!");
using var db = new GameDbContext();

db.Database.EnsureCreated();
Game game = new Game() { 
    Name = "The Witcher 1: Wild Hunt",
    Genre = "RPG",
    Rating = 7.5
};

db.Games.Add(game);
db.SaveChanges();
foreach (var g in db.Games)
{
    Console.WriteLine($"{g.Name} {g.Genre} {g.Rating}");
}