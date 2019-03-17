using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AccountContext :DbContext
    {
        public AccountContext()
            :base ("name=AccountContext")
        {

        }
        public DbSet<Account> Account { get; set; } 
    }
}
