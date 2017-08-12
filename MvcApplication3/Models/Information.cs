using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Information
    {
        private static Information _information;
        public List<Account> Accounts;
        public static Information Context
        {
            get
            {
                if (_information == null)
                {
                    _information = new Information();
                }
                return _information;
            }
        }

        public Information()
        {
            Accounts = new List<Account>();
            Accounts.Add(new Account { Id = 1, UserName = "My name 1", Age = 12 });
            Accounts.Add(new Account { Id = 2, UserName = "My name 2", Age = 12 });
            Accounts.Add(new Account { Id = 3, UserName = "My name 3", Age = 12 });

      
        }
    }
}