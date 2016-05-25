using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionClassLib
{
    public class Class1 : DbContext
    {
        public DbSet<ModelCl> Models { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }

    public class ModelCl
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
