using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_To_One__Person_Passport_.Models
{
    public class Person
    {
        [Key] // Вказує, що це поле є первинним ключем
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // Навігаційна властивість для зв'язку з Passport
        public Passport? Passport { get; set; }
    }
}
