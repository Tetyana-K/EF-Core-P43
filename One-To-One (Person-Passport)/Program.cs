// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using One_To_One__Person_Passport_.Data;
using One_To_One__Person_Passport_.Models;

Console.WriteLine("Person-Passport Example");
using var db = new PersonDbContext();
//Person person = new Person()
//{
//    Name = "Ann",

//    Passport = new Passport()
//    {
//        Number = "AB1234567"
//    }
//};

//db.People.Add(person);
//db.SaveChanges();
DisplayPeopleWithPassports();
ChangePassportNumber(1, "CD7654321");

Console.WriteLine("After changing passport number:");
DisplayPeopleWithPassports();

void DisplayPeopleWithPassports()
{
    foreach (var p in db.People.Include(p=> p.Passport)) // Include для завантаження пов'язаного об'єкта Passport разом з Person
        Console.WriteLine($"{p.Name} has passport number {p.Passport?.Number}");
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
