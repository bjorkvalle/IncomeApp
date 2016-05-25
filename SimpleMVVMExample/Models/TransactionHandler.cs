using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVVMExample.Data;
using SimpleMVVMExample.Enums;
using TransactionClassLib;
using TransactionClassLib.Enums;

namespace SimpleMVVMExample.Models
{
    class TransactionHandler
    {
        public string TransactionMessage { get; internal set; }

        private Repository<Transaction> _repo;

        public TransactionHandler()
        {
            _repo = Repository<Transaction>.GetInstance();
        }

        internal bool AddTransaction(TransactionType type, Transaction transaction)
        {
            decimal value = 0;
            bool canConvert = decimal.TryParse(transaction.CashValue, out value);

            if (!canConvert)
            {
                TransactionMessage = "Cannot convert value";
                return false;
            }
            else if (value <= 0)
            {
                TransactionMessage = "Value must be higher than 0";
                return false;
            }
            else
            {
                TransactionMessage = "Successful transfer";
                transaction.TransferDate = DateTime.Now;
                transaction.Type = type;
                return _repo.Add(transaction);
            }
        }
    }
}
