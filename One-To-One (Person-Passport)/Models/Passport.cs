using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_To_One__Person_Passport_.Models
{
    public class Passport
    {
        [Key] // Вказує, що це поле є первинним ключем
        public int Id { get; set; }
        public string Number { get; set; } = string.Empty;

        [ForeignKey("Person")] // Вказує, що це поле є зовнішнім ключем для зв'язку з Person
        public int PersonId { get; set; }

        // Навігаційна властивість для зв'язку з Person
        public Person? Person { get; set; }
    }
}