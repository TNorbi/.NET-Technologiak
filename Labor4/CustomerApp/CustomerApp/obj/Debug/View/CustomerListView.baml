   M S B A M L   `   `   `  ����F  BCustomerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CustomerApp.ViewCustomerApp.View  5      '    !CustomerApp.View.CustomerListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CustomerApp.View     5        � 	Resources  5	         
RowButtons �� Orientation ��Name �� RelativeSource �� Mode �� AncestorType��%�  &	        �� 5
   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $ bttnEditCustomer��6   $
��Edit��63   ��6B   �� *%#DataContext.ShowCustomerEditCommand+ �� $ FindAncestor=�$ UserControlL��� 5      $ bttnDeleteCustomer��6   $��Delete��65   ��6F   �� *#!DataContext.DeleteCustomerCommand+ �� $ FindAncestor=�$ UserControlL�5      5      5      .��5      �� .+�5   
   �� -   5        $ bttnAddCustomer��5      $��Add Customer��6*   $��90��6l   $��Right=�6w   $��
10 10 0 10q�6�   ��6A   �� *ShowCustomerAddCommand+6�   �� 5   
   -   5         ��Name$ lstVwCustomers��5      ��6+   �� *	Customers+ �� SelectedItem 6M   �� *SelectedCustomer+ �� View 5      �� 5      .P�5      �� $��Company Name��6%   	 �� Width$		 100��6h   
 �� DisplayMemberBinding
 6;   �� *CompanyName+6h   �� 5      $��Contact Name��6%   $		 100��6h   
 6;   �� *ContactName+6h   �� 5!       �� CellTemplate# [  6%   5"      5$      �� 5%   
   -   5         ��Name$ txtBlckMessage��5%       �� Padding$ 3q�6,   ��68   ��  �� Path$ CustomerMessage�5'      5(      