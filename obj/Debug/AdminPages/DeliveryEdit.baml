   M S B A M L   `   `   `  ����D  @SportShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SportShop.AdminPagesSportShop.AdminPages  5      '    !SportShop.AdminPages.DeliveryEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SportShop.AdminPages     5        N� Title$'  !Добавить поставку��5	      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   �  5      �� 5      $��50 �6    6.   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      $	��220 �6    6/    � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      6%   .+�5"      �� $��Поставщик: ��6   $��1��5#      $��0��5$      $��Center=�5%      $��Right=�5&      5'      �� 5(      $��0q�6    �� CornerRadius$ 5��5)      $��1��5*      $��1��5+      ���#fff$��Center=�5-      $
��Left=�5.      ���#9933CC._�50      �� -   5        $��cmbProvider��52         ComboBoxTemplate1#���   50        ComboBoxItemContainerStyle1#���  51      $	��300��53       �� DisplayMemberPath$
 Name��54       �� SelectedValuePath$ ID��56      
������ $��0q�58       �� SelectedItem 55      �� *
Provider+5:       J� Effect 5<      3  -System.Windows.Media.Effects.DropShadowEffect  5=         Color$ #333333��6'   	   ShadowDepth$	 1Q�5>   #   
   Opacity$

 0.15Q�5?   #      
BlurRadius$ 3Q�5@   #   5A      5C      �� 5F      $!��Дата поставки: ��6   $��2��5G      $��0��5H      $��Center=�5I      $��Right=�5J      5K      �� 5L      $��0q�6   $ 5��5M      $��2��5N      $��3��5O      ���#fff$��Center=�5Q      $
��Left=�5R      ���#9933CC._�5T      �� -   5        $��txbDeliveryDate��5T       � Language$ ru-RU�5U      $	��300��5W      
������ $��0q�5Y      ��5V      �� *DeliveryDate+ �� StringFormat$ 
dd.MM.yyyy��.��5Y   .   5Z       5\        5]      $ #333333��6'   $	 1Q�5^   #   $

 0.15Q�5_   #   $ 3Q�5`   #   5a      5c      5e      � 5g   
   $��1��6   ���#fff 5h      �� 5i      6%   �� 5j      6%   .+�5m      �� $��1��6   $
��Left=�5n      $��70 0 0 0q�5o      $��Center=�5p      $��0q�5q      $ 20��5r      ���#e3e3e3���#333333._�5u      �� -   5        $��	btnCancel��5y      $��Отмена��5u      $��0q�5v        myButton#���  5w      
 � Tag$ 20��5x      $
��20 4q�5{      5|       5~        5      $ #333333��6'   $	 2Q�5�   #   $

 0.25Q�5�   #   $ 3Q�5�   #   5�      5�      �� 5�      $��1��6   $��Right=�5�      $��Center=�5�      $��0q�5�      $��0 0 70 0q�5�      $ 20��5�      ���#66CC99���#333333._�5�      �� -   5        $��btnSave��5�      $��Сохранить��5�      $��0q�5�      ���#fff#���  5�      $ 20��5�      $
��20 4q�5�      5�       5�        5�      $ #333333��6'   $	 2Q�5�   #   $

 0.25Q�5�   #   $ 3Q�5�   #   5�      5�      5�      5�      5�      