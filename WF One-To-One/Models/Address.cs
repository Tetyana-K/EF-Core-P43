using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_One_To_One.Models
{
    public  class Address
    {
        [Key, ForeignKey("Person")] // Вказуємо, що PersonId є одночасно первинним ключем і зовнішнім ключем, shared primary key
        public int PersonId { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        
        // Навігаційна властивість для зв'язку з Person
        
        public Person? Person { get; set; } = null!; 
    }
}
