using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.cs
{
    public class AccountBusiness
    {
        private AccountContext accountContext;

        public bool UsernameExist (string username)
        {
            using (accountContext = new AccountContext())
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
            using (accountContext = new AccountContext())
            {
                var item = accountContext.Account.Find(email);
                if (item != null)
                {
                    return false;
                }
                return true;
            }
        }

        public bool UsernameCorrect(string username)
        {
            using (accountContext = new AccountContext())
            {
                var item = accountContext.Account.Find(username);
                if (item != null)
                {
                    return false;
                }
                return true;
            }
        }

        public bool PasswordCorrect(string password)
        {
            using (accountContext = new AccountContext())
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
            using (accountContext = new AccountContext())
            {
                accountContext.Account.Add(account);
                accountContext.SaveChanges();
            }
        }
    }
}
