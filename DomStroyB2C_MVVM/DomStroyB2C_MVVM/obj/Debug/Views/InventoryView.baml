   M S B A M L   `   `   `  ����K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  5      *    $DomStroyB2C_MVVM.Views.InventoryView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:DomStroyB2C_MVVM.Views     5      .��5	      � ���#EDEDED  � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   � $��0��6   ���#4D638C � ColumnDefinitions 5      �� 5      $	��280 �6#   �� 5      $	��280 �6#   �� 5      $��* �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��../Images/employee.png��6   $��27��68   $��27��6C   $��50 0 0 0q�6O   �� 5      $��Jahongir Karimov��6   
�������$��Center=�6G   $
��20px(�6b   $��15 0 0 0q�5      5      � 5       $��1��6   .+�5!      ��    ComboBoxTest2#��[  6   $	��250��6B   $��35��6N   5"      �� 5%      $ 
Horizontal=�6   $��2��62   .+�5&      ��   btnNoneBorder#��[ 6   $��DoingInventory��6f   ��6@   �� *UpdateViewCommand+.��5'      �� $ 
Horizontal=�6!   .+�5(      �� $��../Images/png.png��6    $��35��6;   $��28��6F   �� 5)      $��Tekshiruv yaratish��6$   
�������$��Center=�6Q   $
��20px(�6l   $��10 0 0 0q�5*   $   5+      5.      5/      50      � 53   
   $��1��6   $��0 5 0 0q�6   .+�54      �� -   5         ��Name$ scrollViewer��54      $��Disabled=�61   ��55      �� 56       �� 
TargetType" ��6    �� Triggers 57      �� 58       �� Binding 6*   �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False6]   .a�59   "   �� 	 �� Property	 � ��
 �� Value$

 Auto=�6P   5:      5<      .��5>      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridInventory��5>      $y�Visible=�66   $   HorizontalScrollBarVisibility$
 Auto=�5?      $
��Auto��5@         HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�5C         CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�5K         SelectionMode$ Single=�6)      SelectionUnit$ FullRow=�6@    �� AlternationCount$ 2��5L      $��
20 20 20 0q�5M       � 	Resources 5N        MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� 
TargetType �� CornerRadius��%<  '        7  '  i     7  '  �    '  �    7  '�� �    �� 5O      "  6    8   .�5P      �� 	 �@ GridLinesVisibility$
 
Horizontal=�6D   5Q      �� 5R      "  6    8   .�5S      �� 	 �@�FocusVisualStyle
 6A   Z� �� 5U      	 � ��
 �#7A79796;   �� 5V      	 � ��$
 0q�6@   �� 5X      	 �@��TextAlignment$
 Center=�6H    5Y      P� 5Z   "    �@ 
IsSelected . . �5[   &   �� 	 � ��
 �#B6E0FF6C   5\   #   5_      �� 5b      "  6     5c      P� 5d   "    �@ AlternationIndex$ 0��6F   . �5e   &   �� 	 � ��
 �#FFFFFF6C   5f   #   P� 5g   "    �@ AlternationIndex$ 1��6F   . �5h   &   �� 	 � ��
 �#E3E2E26C   5i   #   5k      �� 5n      "  6    8   .�5o      �� 	 � ��
 �#2836546;   �� 5p      	 � ��

 �����6;   �� 5q      	 � ��$
 55��67   �� 5r      	 � ��$
 Center=�6K   �� 5s      	 � ��$
 Center=�6I   �� 5t      	 � ��$
 30 0 0 0q�68   �� 5u      	 � ��
 5v   "   �� 5w   &   "  66   .R�5x   *   �� $ 	10 10 0 0��5y   -   #��z��5z   -   #��z��5{   -   ._�5|   .   �� $��Center=�6?   $��Center=�6Z   5}   +   5~   '   5�       5�      5�      �� 5�      " ��6    .�5�      �� 	 � ��
 �#2638596;   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn    Header$	  №��6-   !   
IsReadOnly! . "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 80 6a   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 68   �� *id+6a     5�      $  Filial��6-   ! . $
" 200* 6j   # 6=   �� *branch+6j     5�      $
  Sana��6-   ! . $
" 150* 6f   # 6;   �� *date+6f     5�      $  Eski qoldiq��6-   ! . $
" 120* 6q   # 6B   �� *
old_qaun+6q     5�      $  Yangi qoldiq��6-   ! . $
" 120* 6r   # 6C   �� *
new_quan+6r     5�      $  Farq so'mda��6-   ! . $	" 150 6q   # 6B   �� *
diff_som+6q     5�      $  Farq dollarda��6-   ! . $	" 150 6v   # 6D   �� *diff_dollar+6v     5�      $  Tekshiruvchi��6-   ! . $
" 150* 6q   # 6C   �� *	checker+6q     5�      $  Holati��6-   ! . $
" 150* 6m   # 6=   �� *	condition+6m   5�      5�      5�      5�      5�      