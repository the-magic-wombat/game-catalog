using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AccountBusiness
    {
        private GameContext accountContext;

        public bool UsernameExist (string username)
        {
            using (accountContext = new GameContext())
            {
                var item = accountContext.Account.Find(username);
                if(item!=null)
                {
                    return false;
                }
                return true;
            }
        }

        public bool EmailExist(string email)
        {
            using (accountContext = new GameContext())
            {
                var item = accountContext.Account.Find(email);
                if (item != null)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UsernameCorrect(string username)    //working
        {
            using (accountContext = new GameContext())
            {
                var item = accountContext.Account.Where(i => i.Username == username).FirstOrDefault<Account>();    
                if (item != null)
                {
                    return true;
                }
                return false;
            }
        }

        public bool PasswordCorrect(string password)
        {
            using (accountContext = new GameContext())
            {
                var item = accountContext.Account.Find(password);
                if (item != null)
                {
                    return false;
                }
                return true;
            }
        }

        public void Add(Account account)
        {
            using (accountContext = new GameContext())
            {
                accountContext.Account.Add(account);
                accountContext.SaveChanges();
            }
        }
    }
}
