   M S B A M L   `   `   `  ����D  @SportShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SportShop.AdminPagesSportShop.AdminPages  5      '    !SportShop.AdminPages.DeliveryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SportShop.AdminPages     5        N� Title$  Поставки��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   � ���#ffffff.+�5      �� $��Поставки��6   ���#9933CC$��32(�5      $��Center=�5      $��Center=�5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��gridDeliveries��5!         DataGridStyle1#���   5        DataGridCellStyle1   	CellStyle# �  5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5        DataGridRowStyle1   RowStyle# �  5       $��0q�5#      
������ $��1��5%       � Language$ ru-RU�5&         AutoGenerateColumns .     
IsReadOnly .    Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   CanUserResize
 .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *ID+   ElementStyle 5+      �� 5,       �� 
TargetType" ��6    .�5-      ��  �� Property � �� �� Value$ Center=�6D   6U   5.      51        52      $	 Поставщик��6%   
 .  $	 250 6N    6Z   �� *Provider.Name+6~     53      $	 Дата поставки��6%   
 .  $	 250 6R    6^   �� *DeliveryDate+ �� StringFormat$ 
dd.MM.yyyy��6�   4  .System.Windows.Controls.DataGridTemplateColumn  55      $ 35 6)      CellTemplate 56      �� 57      .R�58      �� .+�59   "   �� $��btnEditDelivery��5:   )   -   5        $��0q�59   )     myButton#���  5<   )   .��5=   &   �� $��../Images/edit.png��6,   $��30��6H   6V   5>   #   5?      5@      5B      5D        5G   
   -   5        $��gridComposition��5K      #���   5G      # �  5H      # �  5I      # �  5J      $��0q�5L      
������ $��2��5N       .   .  5Q        5R      $	 ID��6%   
 .  $ 40 6G    6R   �� *ID+ 5S      �� 5T      " ��6    .�5U      ��  � ��$ Center=�6D   6U   5V      5Y        5Z      $!	 Номер поставки��6%   
 .  $	 210 6S    6_   �� *ID_Delivery+6�     5[      $	 
Товар��6%   
 .  $	 300 6J    6V   �� *Product.Name+6y     5\      $	 Кол-во��6%   
 .  $	 120 6K    6W   �� *Amount+6t     5^      $ 35 6)    5_      �� 5`      .R�5a      �� .+�5b   "   �� $��btnEditComposition��5c   )   -   5        $��0q�5b   )   #���  5e   )   .��5f   &   �� $��../Images/edit.png��6,   $��30��6H   6V   5g   #   5h      5i      5k      5m      � 5o   
   ���#ffffff$��3��5p       � ColumnDefinitions 5q      �� 5r      $	��400 �6#   61   �� 5s      6%   .+�5v      �� $��1��6   $��Center=�5w      $��4q�5x       �� CornerRadius$ 5��5y      ���#66CC99$
��Left=�5{      ._�5|      �� -   5        $��btnAdd��5|      $
��15 4q�5~      ���#fff$��0q�5�      
������ #���  5�      $��Добавить��5�      5�      5�      �� 5�      $��1��6   $��Center=�5�      $��4q�5�      $��45 0 0 0q�5�      $ 5��5�      ���#66CC99$��Center=�5�      ._�5�      �� -   5        $��btnAddComposition��5�      $
��15 4q�5�      ���#fff$��0q�5�      
������ #���  5�      $&�� Добавить в состав��5�      5�      5�      �� 5�      $��1��6   $��Center=�5�      $��4q�5�      $ 5��5�      ���#E04F5F$��0 0 40 0q�5�      $��Right=�5�      ._�5�      �� -   5        $��	btnDelete��5�      $��5q�5�      ���#fff$��0q�5�      
������ #���  5�      .��5�      �� $��../Images/delete.png��6   6<   5�      5�      5�      5�      5�      