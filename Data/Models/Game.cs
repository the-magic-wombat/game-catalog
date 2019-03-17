using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Date { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
    }
}
