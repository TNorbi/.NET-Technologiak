   M S B A M L   `   `   `  ����F  BCustomerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CustomerApp.DialogsCustomerApp.Dialogs  5   	   =#clr-namespace:CustomerApp.ViewModelCustomerApp.ViewModel  5   	   (    "CustomerApp.Dialogs.CustomerDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CustomerApp.Dialogs     5   	   2vm#clr-namespace:CustomerApp.ViewModel     5   	     � Title$  CustomerDialog��5	   	    � WindowStartupLocation$ CenterOwner=�5
   	    � 
ResizeMode$ NoResize=�5   	   $	��200��5   	   $	��300��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��10q�6   $��0��6   $��3��6)   $
��Bold"�6=   $��Center=�6O   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5          CustomerApp.ViewModel.Mode
   Add �� Value# Z 6D   	 �� Binding	 6&   �� 
 �� Path$

 Mode�.a�5      ��  �� Property � �� �� Value$ Add Customer��68   5       �� 5!         Edit# Z 6D   	 6&   �� $

 Mode�.a�5"      ��  � ��$ Edit Customer��68   5#      5%      5'      �� 5(   
   $��10q�6   $��1��6    $��0��6-   $��Company Name��6=   �� 5)   
   $��10q�6   $��2��6   $��1��62   $��1��6?   ��6O   �� *CompanyName+�� 5+   
   $��10q�6   $��2��6    $��0��6-   $��Contact Name��6=   �� 5,   
   $��10q�6   $��2��6   $��2��62   $��1��6?   ��6O   �� *ContactName+�� 5.   
   $��10q�6   $��3��6   $��1��6*   ��6:   �� *UpdateAddCommand+��50      �� 51      " ��6    52      �� 53      # Z 6?   	 6&   �� *Mode+.a�54      ��  � ��$	 Add��68   55      �� 56      # Z 6?   	 6&   �� *Mode+.a�57      ��  � ��$
 Save��68   58      5:      5<      �� 5=   
   -   5         ��Name$ 
cancelBttn��5=      $��10q�6%   $��3��61   $��2��6>   $��Cancel��6N   ��6_   �� *CancelCommand+5?      5@      