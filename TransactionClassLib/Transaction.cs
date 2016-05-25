using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionClassLib.Enums;

namespace TransactionClassLib
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string CashValue { get; set; }
        public TransactionType Type { get; set; }
        public DateTime? TransferDate { get; set; }

        public Transaction()
        {
            CashValue = "0";
        }

        public override string ToString()
        {
            return $"Id:{Id}, CashValue: {CashValue}, TransType: {Type}, TransferDate: {TransferDate}";
        }
    }
}
