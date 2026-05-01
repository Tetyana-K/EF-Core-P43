using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Test.Models
{
    public  class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Genre { get; set; }

        [Range(0, 10, ErrorMessage ="Rating should be 0..10")]
        public double Rating { get; set; } = 0;
    }
}
