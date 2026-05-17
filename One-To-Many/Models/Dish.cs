using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_To_Many.Models
{
    public class Dish
    {
        public int Id { get; set; } // первинний ключ (Primary Key) за замовчуванням (на основі домовленостей =conventions). EF Core автоматично розпізнає властивість з назвою Id

        [Required, MaxLength(50)]
        public string Name { get; set; } = String.Empty;

        [Required, MaxLength(100)]
        public string Description { get; set; } = String.Empty;

        [Range(0.0, 1000.0, ErrorMessage = "Price must be between 0 and 1000.")] // валідація для ціни, щоб вона була в межах від 0 до 1000. Це приклад використання атрибута валідації для забезпечення коректності даних
        // не зайде в базу даних як обмеження. не усі атрибути валідації автоматично перетворюються на обмеження бази даних.
        // Деякі атрибути, такі як [Required] та [MaxLength], можуть впливати на схему бази даних,
        // тоді як інші, такі як [Range], використовуються лише для валідації на рівні додатка і не створюють відповідних обмежень у базі даних.
        public decimal Price { get; set; } // decimal співставляється з типом money в SQL Server, що дозволяє зберігати точні значення для цін (decimal 18, 2)

        //[ForeignKey("Menu")] //можемо вказати явно, що це зовн ключ (1-й спосіб)
        public int MenuId { get; set; } // Foreign key для Меню, можна не задавати, EF Core сам створить це поле (але маємо кращий контроль та читабельність, якщо задамо)

        //[ForeignKey(nameof(MenuId))] // або так (2-й спосіб) – вказуємо, що MenuId є зовнішнім ключем для навігаційної властивості Menu
        public Menu? Menu { get; set; } // навігаційна властивість. Menu? – nullable, оскільки страва може бути не прив'язана до жодного меню (хоча в реальному житті це малоймовірно, але для демонстрації можливостей EF Core це допустимо)
    }
}
