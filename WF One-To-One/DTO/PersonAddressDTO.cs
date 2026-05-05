using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_One_To_One.DTO
{
// DTO (Data Transfer Object) для об'єднання даних з двох таблиць Person та Address
    internal class PersonAddressDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Empty, бо це DTO, і ми не хочемо мати null-значення, а краще пусті рядки
        public int Age { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
}
