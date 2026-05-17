using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_To_Many.Models
{
    public class Menu
    {
        //[Key]
        public int Id { get; set; } // первинний ключ (Primary Key) за замовчуванням (на основі домовленостей =conventions). EF Core автоматично розпізнає властивість з назвою Id

        [Required, MaxLength(50)] // MaxLength(50) – обмежує довжину рядка до 50 символів, що відповідає типу nvarchar(50) в SQL Server
        public string Name { get; set; } = String.Empty;

        // навігаційна властивість (список, часто роблять як ICollection) – одне меню має багато страв
        public List<Dish> Dishes { get; set; } = new List<Dish>();

    }
}
