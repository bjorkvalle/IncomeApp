using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionClassLib;

namespace TestClassLibraryEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction m = new Transaction
            {
                CashValue = 100.ToString(),
                TransferDate = DateTime.Now,
                Type = TransactionClassLib.Enums.TransactionType.Income
            };
            Repository<Transaction>.GetInstance().Add(m);

            Console.WriteLine(Repository<Transaction>.GetInstance().GetAll().First().ToString());
            Console.Read();
        }
    }
}
