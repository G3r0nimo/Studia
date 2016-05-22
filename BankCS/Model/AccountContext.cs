using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCS.Model
{
    public class AccountContext : DbContext
    {
        internal object Account;

        public DbSet<Account> Accounts { get; set; }
        public object Client { get; internal set; }
        public DbSet<Person> People { get; set; }
    }
}
