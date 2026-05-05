using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_P43.Models
{
    // клас сутності Студент
   // [Table("Peoples")]
    public class Student // сутність, яка буде відображатися (мапитися) на таблицю в базі даних (Students)
    {
        // Id - буде як первинний ключ, EF Core сам розпізнає (неявно)
        // Назва властивості, яку хочемо зробити первинним ключем  повинна бути Id або StudentId (ClassNameId)
        public int Id { get; set; }
        //public int StudentId { get; set; }
        public string Name { get; set; }
       // [Range(16, 100, ErrorMessage = "Age must be between 16 and 100.")]
        public int Age { get; set; }
        public string Group { get; set; }
        
        public double Grade { get; set; } = 0;

    }
}
