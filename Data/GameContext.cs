using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GameContext :DbContext
    {
        public GameContext()
            :base ("name=GameContext")
        {

        }
        public DbSet<Game> Game { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
