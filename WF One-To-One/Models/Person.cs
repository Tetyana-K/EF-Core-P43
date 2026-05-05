using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_One_To_One.Models
{
    public class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public Address? Address { get; set; }
    }
}
