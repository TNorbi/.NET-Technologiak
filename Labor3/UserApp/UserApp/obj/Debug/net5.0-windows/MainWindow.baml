   M S B A M L   `   `   `  ����B  >UserApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:UserAppUserApp  5   	   +clr-namespace:UserApp.ViewUserApp.View  5   	       UserApp.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:UserApp     5   	   )vwclr-namespace:UserApp.View     5   	     � Title$  
MainWindow��5	   	   $
��auto��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   !   UserApp.View.CollectionView  $��0��6   �� 5   
   -   5         ��Name$ mainStackPanel��5       �� Orientation$ Vertical=�6-   $��1��6D    � DataContext 6Q   �� *MainViewModel.User+.+�5      �� 
���   �$��28(�5      $��Center=�5      $��Center=�5      ��5      �� *Name+5      �� 5      
���   �$��28(�5      $��Center=�5      $��Center=�5      ��5      �� *Age+5      �� 5       
���   �$��28(�5"      $��Center=�5#      $��Center=�5$      ��5       �� *Gender+5$      5%      �� 5(   
   $ Vertical=�6   $��2��6,   .+�5)      �� $��New Name��6   �� 5*      -   5         ��Name$ 
txtNewName��5*      $��10q�5+      �� 5-      $��New Age��6   �� 5.      -   5        $ 	txtNewAge��5.      $��10q�5/      �� 51      $��
New Gender��6   �� 52      -   5        $ txtNewGender��52      $��10q�53      �� 55      -   5         ��Name$ btnChangeUserDatas��55      $��Személy módositása��56      $��10q�57      $��Center=�6!   58      5:      5;      5<      