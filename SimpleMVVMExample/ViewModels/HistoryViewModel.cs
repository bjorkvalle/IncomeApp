//using SimpleMVVMExample.Data;
using SimpleMVVMExample.Data;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using TransactionClassLib;

namespace SimpleMVVMExample.ViewModels
{
    class HistoryViewModel
    {
        public ObservableCollection<Transaction> Transactions { get; set; }

        public HistoryViewModel()
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            Transactions = new ObservableCollection<Transaction>();
            Repository<Transaction>.GetInstance().GetAll().Reverse().Take(5).ToList().ForEach(t => Transactions.Add(t));
        }
    }
}
