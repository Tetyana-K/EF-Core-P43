using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_P43.Models
{
    // клас сутності Студент
    public class Student
    {
        // Id - буде як первинний ключ, EF Core сам розпізнає (неявно)
        // Назва властивості, яку хочемо зробити первинним ключем  повинна бути Id або StudentId (ClassNameId)
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Age { get; set; }
        public string Group { get; set; }
        public double Grade { get; set; } = 0;

    }
}
