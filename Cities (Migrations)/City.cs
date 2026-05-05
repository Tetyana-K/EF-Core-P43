using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities__Migrations_
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Population { get; set; }
       
        [MaxLength(50)]
        public string Country { get; set; } = string.Empty;

        //public int ZipCode { get; set; }
    }
}
