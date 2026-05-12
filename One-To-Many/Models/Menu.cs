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
        public int Id { get; set; } // первинний ключ (Primary Key) за замовчуванням (на основі домовленостей =conventions). EF Core автоматично розпізнає властивість з назвою Id

        [Required, MaxLength(50)]
        public string Name { get; set; } = String.Empty;

        // навігаційна властивість (список, часто роблять як ICollection) – одне меню має багато страв
        public List<Dish> Dishes { get; set; } = new List<Dish>();

    }
}
