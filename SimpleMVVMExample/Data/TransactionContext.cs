using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVMExample.Data
{
    public class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
    }
}
