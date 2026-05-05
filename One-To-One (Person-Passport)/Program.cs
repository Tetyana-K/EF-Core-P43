// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using One_To_One__Person_Passport_.Data;
using One_To_One__Person_Passport_.Models;

Console.WriteLine("Person-Passport Example");
using var db = new PersonDbContext();
//Person person = new Person()
//{
//    Name = "Ihor",

//    Passport = new Passport()
//    {
//        Number = "FF1234567"
//    }
//};

//db.People.Add(person);
//db.SaveChanges();
DisplayPeopleWithPassports();
DisplayAllPassports();

//ChangePassportNumber(1, "AA7654321");

//Console.WriteLine("After changing passport number:");
//DisplayPeopleWithPassports();

//Console.WriteLine("After removing person number:");
RemovePerson(2);
DisplayAllPassports();
void DisplayPeopleWithPassports()
{
    foreach (var p in db.People.Include(p=> p.Passport)) // Include для завантаження пов'язаного об'єкта Passport разом з Person
        Console.WriteLine($"{p.Id} {p.Name} has passport number {p.Passport?.Number}");
}
void ChangePassportNumber(int personId, string newNumber)
{
    var person = db.People.Find(personId);
    if (person != null && person.Passport != null)
    {
        person.Passport.Number = newNumber;
        db.SaveChanges();
    }
}
void RemovePerson(int personId)
{
    var person = db.People.Find(personId);
    var name = person?.Name;
    if (person != null)
    {
        db.People.Remove(person);
        db.SaveChanges();
        Console.WriteLine($"Person with ID {personId} and name {name}  has been removed.");
    }
    
}
void DisplayAllPassports()
{
    foreach (var passport in db.Passports)
        Console.WriteLine($"Passport number: {passport.Number}");   
}