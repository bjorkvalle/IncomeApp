   M S B A M L   `   `   `  ����L  HSimpleMVVMExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SimpleMVVMExample.ViewsSimpleMVVMExample.Views  5      -    'SimpleMVVMExample.Views.TransactionView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:SimpleMVVMExample.Views     5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ grdCashValue��5   "   $��0��6   $��Center=�68   $	��5,0q�6S   .+�5      �� -   5         ��Name$ tbxCashInput��5      $��24(�5      
������    MainTxtColor#��[  5   /   $
��Bold"�6Z   $��Center=�5      $��Stretch=�6:   $��Center=�5      ��5   ,   �� *CurrentTransaction.CashValue+ �� Mode$ TwoWay=���5   $   Z� 5      �� 5      
������   ErrorTxtColor#��[ 5   1   $��Center=�5      $��Center=�65   $��12(�6P   ��5      �� *MessageHdlr.Message+$ OneWay=�5   P   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5       � -   5         �Name$ 	grdIncome��5    #   $��0��6   .+�5!      � ���	#FF1F951F$��70��6.   �� 5"      -   5         ��Name$ 	btnIncome��5"      $�� ��6G   ���	#FF28C728$��60��5#   0   $	��Top=�6<   
������ $��INCOME��5$      $��18(�6*   #��[  68   $
��Bold"�6c   ��5"   ,   �� *Income+5$   c   5%      � 5&      -   5        $ 
grdExpense��5&   #   $��1��6   .+�5'      � ���	#FFA20F2C$��70��6.   �� 5(      -   5        $ 
btnExpense��5(      $�� ��6I   
���<��$��60��5)   .   $	��Top=�6:   
������ $��EXPENSE��5*      $��18(�6+   #��[  69   $
��Bold"�6d   ��5(   -   �� *	Expense+5*   d   5+      5,      5.      5/      