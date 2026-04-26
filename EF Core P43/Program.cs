// See https://aka.ms/new-console-template for more information
using EF_Core_P43.Data;
using EF_Core_P43.Models;

Console.WriteLine("---Hello from EF Core----");


using var db = new StudentDbContext(); // Створення екземпляру контексту бази даних,
                                       // using забезпечує автоматичне звільнення ресурсів після використання

//db.Database.EnsureDeleted(); // Видалення бази даних, якщо вона існує (для чистого старту при кожному запуску програми)
db.Database.EnsureCreated(); // Створення бази даних, якщо вона ще не існує

Student student = new Student
{
    Name = "Nazar Voitivich",
    Age = 16,
    Group = "CS102",
    Grade = 78.5
};

//db.Students.Add(student);
//db.SaveChanges(); // Збереження змін у базі даних

//foreach (var s in db.Students)
//{
//    Console.WriteLine($"{s.Name} {s.Age} {s.Grade}");

//}

//AddStudent(student, db);
ShowAll(db);
//UpdateStudentName(db, "Matvii", "Sergii Matvienko");
//Console.WriteLine("\nAfter updating");

string nameForDelete = "Sergii";
DeleteStudent(db, nameForDelete);
Console.WriteLine("After deleting:");
ShowAll(db);


void AddStudent(Student student, StudentDbContext db)
{
    db.Students.Add(student);
    db.SaveChanges();
}
void ShowAll(StudentDbContext db)
{
    var students = db.Students.ToList(); // виконання SQL-запиту до бази і завантаження результату в пам’ять, актулізація даних з бази даних, отримання всіх записів з таблиці Студенти і перетворення їх у список об’єктів Student
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
    db.Students.Remove(student);
    db.SaveChanges();
}

