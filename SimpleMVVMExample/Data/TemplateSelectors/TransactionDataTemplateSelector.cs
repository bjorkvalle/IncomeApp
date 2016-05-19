using SimpleMVVMExample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SimpleMVVMExample.Data.TemplateSelectors
{
    class TransactionDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate IncomeTemplate { get; set; }
        public DataTemplate ExpenseTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Transaction transaction = item as Transaction;

            if (transaction.Type == Enums.TransactionType.Income)
                return IncomeTemplate;
            else
                return ExpenseTemplate;
        }
    }
}
