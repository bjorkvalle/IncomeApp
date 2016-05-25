using SimpleMVVMExample.Data;
using SimpleMVVMExample.Enums;
using SimpleMVVMExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TransactionClassLib;
using TransactionClassLib.Enums;

namespace SimpleMVVMExample.ViewModels
{
    class TransactionViewModel
    {
        public ICommand Income { get { return new RelayCommand(AddIncomeTransaction); } }
        public ICommand Expense { get { return new RelayCommand(AddExpenseTransaction); } }
        public MessageHandler MessageHdlr { get; set; }
        public TransactionHandler TransactionHdlr { get; set; }
        public Transaction CurrentTransaction { get; set; }

        public TransactionViewModel()
        {
            CurrentTransaction = new Transaction();
            TransactionHdlr = new TransactionHandler();
            MessageHdlr = new MessageHandler();
        }

        private void AddIncomeTransaction(object obj) //obj är commandparameter i xaml
        {
            TransactionHdlr.AddTransaction(TransactionType.Income, CurrentTransaction);
            Console.WriteLine(MessageHdlr.Message = TransactionHdlr.TransactionMessage);
        }

        private void AddExpenseTransaction(object obj)
        {
            TransactionHdlr.AddTransaction(TransactionType.Expense, CurrentTransaction);
            Console.WriteLine(MessageHdlr.Message = TransactionHdlr.TransactionMessage);
        }
    }
}
