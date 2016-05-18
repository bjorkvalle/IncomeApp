using SimpleMVVMExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMVVMExample.ViewModels
{
    class MainViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand TransactionNavigation { get { return new RelayCommand(NavigateToTransaction); } }
        public ICommand HistoryNavigation { get { return new RelayCommand(NavigateToHistory); } }

        private object _currentViewModel;
        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public MainViewModel()
        {
            CurrentViewModel = new TransactionViewModel(); //login?
        }

        private void NavigateToTransaction(object obj)
        {
            CurrentViewModel = new TransactionViewModel();
        }
        private void NavigateToHistory(object obj)
        {
            CurrentViewModel = new HistoryViewModel();
        }

        private void OnPropertyChanged(string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
