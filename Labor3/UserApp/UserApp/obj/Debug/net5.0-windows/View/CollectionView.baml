   M S B A M L   `   `   `  ����B  >UserApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:UserApp.ViewUserApp.View  5      !    UserApp.View.CollectionView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:UserApp.View     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ listView��5      
�������
���   ���6%   �� *Users+��5      �� 5      .R�5      �   5      �� 5      �� 5      $
��Auto �6,   �� 5      $
��Auto �6,    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6$   $��24(�5         �� Padding$ 10q�5!       ��5   4   �� *Name+5!       �� 5#      $��1��6$   $��24(�5$       $ 10q�5%       ��5#   4   �� *Age+5%       �� 5'      $��2��6$   $��24(�5(       $ 10q�5)       ��5'   4   �� *Gender+5)       5*      5,      5.      � 50   
   $��1��6   $��10q�6     51      �� 52      �� 53      $
��Auto �6    �� 54      �� 55      $
��Auto �6    �� 56      �� 57      $
��Auto �6    �� 58      �� 59      $
��Auto �6     5;      �� 5<      �� 5=      $
��Auto �6#   .+�5@      �� $��0��6   $��	User Name��6%   �� 5A      -   5         ��Name$ txtUserName��5A   #   $��1��6   6#   �� 5C      $��2��6   $	��Age��6%   $��0,5,0,0q�60   �� 5D      -   5        $ txtAge��5D   #   $��3��6   6#   �� 5F      $��Gender��6   $��4��5G      $��0,5,0,0q�5H      �� 5I      -   5        $ 	txtGender��5I      $��5��5J      �� 5L      -   5         ��Name$ btnAddNewUser��5L   "   $��6��6   $��Új felhasználó��5M      $��0��5N      $��0,8,0,0q�5O      5P      5Q      5R      5S      