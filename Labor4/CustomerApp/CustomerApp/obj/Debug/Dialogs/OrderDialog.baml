   M S B A M L   `   `   `  ����F  BCustomerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CustomerApp.DialogsCustomerApp.Dialogs  5   	   =#clr-namespace:CustomerApp.ViewModelCustomerApp.ViewModel  5   	   %    CustomerApp.Dialogs.OrderDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CustomerApp.Dialogs     5   	   2vm#clr-namespace:CustomerApp.ViewModel     5   	     � Title$  OrderDialog��5	   	    � WindowStartupLocation$ CenterOwner=�6    � 
ResizeMode$ NoResize=�5
   	   $	��200��5   	   $	��380��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��10q�6   $��0��6   $��3��6)   $
��Bold"�6=   $��Center=�6O   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5          CustomerApp.ViewModel.Mode
   Add �� Value# Z 6D   	 �� Binding	 6&   �� 
 �� Path$

 Mode�.a�5       ��  �� Property � �� �� Value$ 	Add Order��68   5!      �� 5"         Edit# Z 6D   	 6&   �� $

 Mode�.a�5$      ��  � ��$ 
Edit Order��68   5%      5'      5)      �� 5*   
   $��10q�6   $��1��6    $��0��6-   $��Order Description��6=   �� 5+   
   -   5         ��Name$ txtBxDescription��5+         validationStyle#��[  6,   $��10q�6U   $��2��5,      $��1��6   $��1��6"   ��62   �� *Description+ �� ValidatesOnDataErrors .  �� NotifyOnValidationError .  �� UpdateSourceTrigger$ 	LostFocus=��� 5/   
   $��10q�6   $��2��6    $��0��6-   $��Quantity��6=   �� 50   
   -   5        $ txtBxQuantity��50      #��[  6)   $��2��6R   $��10q�6f   $��2��6r   $��1��6   ��6�   �� *
Quantity+ .  . $ 	LostFocus=��� 53   
   -   5         ��Name$ 	btnUpdate��53      $��10q�6$   $��3��60   $��1��6=   ��6M   �� *UpdateAddCommand+��55      �� 56      " ��6   .�57      ��  � {� .  62    58      �� 59      # Z 6?   	 6&   �� *Mode+.a�5;      ��  � ��$	 Add��68   5<      �� 5=      # Z 6?   	 6&   �� *Mode+.a�5?      ��  � ��$
 Save��68   5@      ^� 5A       ^� 
Conditions 5B      �� 5C   "    �� Binding 6,   ��  �� ElementName$ txtBxQuantity��$
 (Validation.HasError)� �� Value	 false6u   �� 5E   "    6,   �� $ txtBxDescription��$
 (Validation.HasError)�	 false6y   .0�5H      ��  � {� . 6:   5I      5K      5M      �� 5N   
   -   5        $ 
cancelBttn��5N      $��10q�6%   $��3��61   $��2��6>   $��Cancel��6N   ��6_   �� *CancelCommand+5O      5P      