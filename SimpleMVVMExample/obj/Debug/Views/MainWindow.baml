   M S B A M L   `   `   `  ����L  HSimpleMVVMExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SimpleMVVMExampleSimpleMVVMExample  5   	   K*clr-namespace:SimpleMVVMExample.ViewModelsSimpleMVVMExample.ViewModels  5   	   A%clr-namespace:SimpleMVVMExample.ViewsSimpleMVVMExample.Views  5   	   "    SimpleMVVMExample.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SimpleMVVMExample     5   	   A
viewModels*clr-namespace:SimpleMVVMExample.ViewModels     5   	   7views%clr-namespace:SimpleMVVMExample.Views     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)    � DataContext 5      0  *SimpleMVVMExample.ViewModels.MainViewModel  5   
    � 	Resources 5       �� DataType7  1SimpleMVVMExample.ViewModels.TransactionViewModel-   'SimpleMVVMExample.Views.TransactionView3  -SimpleMVVMExample.ViewModels.HistoryViewModel)   #SimpleMVVMExample.Views.HistoryView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �    MainBgColor#��[  6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"     
NavBgColor#��[ 6;   $��20��6d   .+�5!      � -   5         �Name$ grdTransaction��5!      $��5,0,10,0q�6+   .+�5"      � $	��Top=�6   �� 5#      $��| TRANSACTION |��6   $��10(�63   $�� ��5$   D     NavTxtColor#��[ 5%      
������ 
������ $��Center=�5&      $��Center=�66   ��5$      �� *TransactionNavigation+5&   6   5'      � 5)      -   5        $ 
grdHistory��5)      .+�5*      � $	��Top=�6   �� 5+      $��| HISTORY |��6   $��10(�6/   $�� ��5,   ?   #��[ 5-      
������ 
������ $��Center=�5.      $��Center=�66   ��5,      �� *HistoryNavigation+5.   6   5/      50      �� 52   
   $��1��6   ��6&   �� *CurrentViewModel+53      54      