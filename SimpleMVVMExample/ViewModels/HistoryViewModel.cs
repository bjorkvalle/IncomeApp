using SimpleMVVMExample.Data;
using System;
using System.Collections.ObjectModel;
using System.Linq;

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
            Repository<Transaction>.GetInstance().GetList().Reverse().Take(5).ToList().ForEach(t => Transactions.Add(t));
        }
    }
}
