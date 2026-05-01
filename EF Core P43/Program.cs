// See https://aka.ms/new-console-template for more information
using EF_Core_P43.Data;
using EF_Core_P43.Models;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

using var db = new StudentDbContext(); // Створення екземпляру контексту бази даних,
                                      // using забезпечує автоматичне звільнення ресурсів після використання

    //db.Database.EnsureDeleted(); // Видалення бази даних, якщо вона існує (для чистого старту при кожному запуску програми)
    //db.Database.EnsureCreated(); // Створення бази даних, якщо вона ще не існує

    Student student = new Student
    {
        Name = "Ivan",
        Age = 16,
        Group = "D100",
        Grade = 98.5
    };

    //db.Students.Add(student);
    //db.SaveChanges(); // Збереження змін у базі даних

    //foreach (var s in db.Students)
    //{
    //    Console.WriteLine($"{s.Name} {s.Age} {s.Group} {s.Grade}");

    //}


    AddStudent(student, db);
    ShowAll(db);
    
    UpdateStudentName(db, "Ivan", "Ivan Matvienko");
    Console.WriteLine("\nAfter updating");

    string nameForDelete = "Olena";
    DeleteStudent(db, nameForDelete);
    Console.WriteLine("After deleting:");
    ShowAll(db);


void AddStudent(Student student, StudentDbContext db)
{
    db.Students.Add(student); // Додавання нового студента до контексту бази даних, але зміни ще не збережені в базі даних
    db.SaveChanges(); // Збереження змін у базі даних
}
void ShowAll(StudentDbContext db)
{
    var students = db.Students.ToList(); // виконання SQL-запиту до бази і завантаження результату в пам’ять, актулізація даних з бази даних, отримання всіх записів з таблиці Студенти і перетворення їх у список об’єктів Student
    //db.Students -  “опис запиту”
    // db.Students.ToList() - виконання запиту і отримання результату у вигляді списку об’єктів Student
            //дані завантажені в пам'ять
            //SQL запит виконався
            //тепер це звичайний List
    if (students.Count() == 0)
    {
        Console.WriteLine("Empty students' list");
        return;
    }

    foreach (var s in students)
    {
        Console.WriteLine($"{s.Name}\t{s.Age}\t{s.Group }\t{s.Grade}");

    }
}
 void UpdateStudentName (StudentDbContext db, string name, string newName)
{
    var student = db.Students.FirstOrDefault(x => x.Name.Contains(name));
    if (student == null)
    {
        Console.WriteLine($"Student {name} not found ");
        return;
    }
    if (student.Name != newName)
    {
        // Зміна імені студента в об’єкті, який відстежується контекстом бази даних.
        // EF Core розпізнає цю зміну і позначить цей об’єкт як змінений (Modified)
        student.Name = newName; 
        db.SaveChanges();
        Console.WriteLine($"Student {name} is updated to {newName}");
    }
}

void DeleteStudent(StudentDbContext db, string name)
{
    var student = db.Students.FirstOrDefault( x => x.Name.Contains(name));
    if (student == null)
    {
        Console.WriteLine($"Deleteing: student {name} not found");
        return;
    }
    db.Students.Remove(student);// Видалення студента з контексту бази даних, але зміни ще не збережені в базі даних
    db.SaveChanges(); // Збереження змін у базі даних, фактичне видалення запису з таблиці Студенти
}

