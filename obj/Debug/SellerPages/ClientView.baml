   M S B A M L   `   `   `  ����D  @SportShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SportShop.SellerPagesSportShop.SellerPages  5      &     SportShop.SellerPages.ClientView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SportShop.SellerPages     5        N� Title$  Клиенты��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   � ���#ffffff.+�5      �� $��Клиенты��6   ���#9933CC$��32(�5      $��Center=�5      $��Center=�5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��gridClients��5          DataGridStyle1#���   5        DataGridCellStyle1   	CellStyle# �  5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5        DataGridRowStyle1   RowStyle# �  5       � Language$ ru-RU�5!      $��0q�5"      
������ $��1��5$         AutoGenerateColumns .     
IsReadOnly .    Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   CanUserResize
 .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *ID+   ElementStyle 5)      �� 5*       �� 
TargetType" ��6    .�5+      ��  �� Property � �� �� Value$ Center=�6D   6U   5,      5/        50      $	 Фамилия��6%   
 .  $	 140 6L    6X   �� *
LastName+6w     51      $	 Имя��6%   
 .  $	 130 6H    6T   �� *	FirstName+6t     52      $	 Отчество��6%   
 .  $	 150 6M    6Y   �� *
Patronymic+6z     53      $	 Телефон��6%   
 .  $	 140 6L    6X   �� *Phone+6t     54      $	 Дата рождения��6%   
 .  $
 auto 6R    6_   �� *DateOfBirth+ �� StringFormat$ 
dd.MM.yyyy��6�   4  .System.Windows.Controls.DataGridTemplateColumn  56      $ 35 6)      CellTemplate 57      �� 58      .R�59      �� .+�5:   "   �� $��btnEdit��5;   )   -   5        $��0q�5:   )     myButton#���  5=   )   .��5>   &   �� $��../Images/edit.png��6,   $��30��6H   6V   5?   #   5@      5A      5C      5E      � 5G   
   ���#ffffff$��2��5H       � ColumnDefinitions 5I      �� 5J      6%   �� 5K      6%   .+�5N      �� $��1��6   $��Center=�5O      $��4q�5P       �� CornerRadius$ 5��5Q      ���#66CC99$��Center=�5T      ._�5U      �� -   5        $��btnAdd��5U      $
��15 4q�5W      ���#fff$��0q�5Y      
������ #���  5[      $��Добавить��5\      5]      5^      �� 5`      $��1��6   $��Center=�5a      $��4q�5b      $ 5��5c      ���#E04F5F$��0 0 70 0q�5e      $��Right=�5f      ._�5g      �� -   5        $��	btnDelete��5g      $��5q�5h      ���#fff$��0q�5k      
������ #���  5m      .��5n      �� $��../Images/delete.png��6   6<   5o      5p      5q      5r      5s      