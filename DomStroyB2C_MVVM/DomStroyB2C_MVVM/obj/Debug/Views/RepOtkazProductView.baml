   M S B A M L   `   `   `  ����K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  5      0    *DomStroyB2C_MVVM.Views.RepOtkazProductView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:DomStroyB2C_MVVM.Views     5        � 	Resources  5	       �� 
TargetType   txtText �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�64   5      5      .��5      � ���#E5E5E5 � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��80 �6   .+�5   
   � $��0��6   ���#4D638C � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5       �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5!      �� $
��Sale��6?   ��6   �� *UpdateViewCommand+��5"      �� 5#      " ��6    .�5$      ��  � ��$ 40��66   �� 5%       � ��$ 40��67   �� 5&       � ��
 ���� 6;   �� 5'       � ��$
 Left=�6D   �� 5(       � ��$ 25 0 0 0q�67   �� 5)       � �� 5*   "   �� 5+   &    �� 
TargetType" ��66   .R�5,   *   �� #��z��5-   )   #��z��5.   )   ._�5/   .   �� $��Center=�6?   $��Center=�6Z   50   +   51   '   53       �� Triggers 54      P� 55   "   	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �56   &   ��  � �� �#2836546C   �� 57   &    � �� �#2836546D   58   #   5:      .��5<      �� $��../Images/imageback.png��6   $��30��6=   $��30��6H   5=      �� 5>      $"��Qaytarib olingan mahsulotlar��6   #��[  6@   $
��20px(�6a   $��30 0 0 0q�6q   5?      � 5B      $��1��6   .+�5C      ��   	txtSearch#��[ 6   $	��564��5D      $��34��6"   $��Center=�6.   $��Right=�6I   $��0 0 20 0q�5E      $��	30 5 50 5q�6(   �� 5G      $��../Images/search.png��6   $��20��66   $��20��6B   $��Center=�5H      $��Right=�6/   $��0 0 35 0q�5I      5J      5L      � 5O   
   $��1��6   $��0 20 0 0q�6   .+�5P      �� -   5         ��Name$ scrollViewer��5P      $��Disabled=�61   ��5Q      �� 5R      " ��6    5S      �� 5T       �� Binding 6*   �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False6]   .a�5U   "   ��  � ��$
 Auto=�6P   5V      5X      .��5Z      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridClient��5Z      $y�Visible=�63   $   HorizontalScrollBarVisibility$
 Auto=�5[      $
��Auto��5\         HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�5_         CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�5g         SelectionMode$ Single=�6)      SelectionUnit$ FullRow=�6@    �� AlternationCount$ 2��5h      $��	25 0 25 0q�5i        5j        MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� CornerRadius��%<  '        7  '  i     7  '  �    '  �    7  '�� �    �� 5k      "  6    8   .�5l      ��  �@ GridLinesVisibility$ 
Horizontal=�6D   5m      �� 5n      "  6    8   .�5o      ��  �@�FocusVisualStyle 6A   Z� �� 5q       � �� �#7A79796;   �� 5r       � ��$ 0q�6@   �� 5t       �@��TextAlignment$ Center=�6H    5u      P� 5v   "   	 �@ 
IsSelected
 . . �5w   &   ��  � �� �#4D638C6C   5x   #   5{      �� 5~      "  6     5      P� 5�   "   	 �@ AlternationIndex$
 0��6F   . �5�   &   ��  � �� �#FFFFFF6C   5�   #   P� 5�   "   	 �@ AlternationIndex$
 1��6F   . �5�   &   ��  � �� �#E3E2E26C   5�   #   5�      �� 5�      "  6    8   .�5�      ��  � �� �#2836546;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 55��67   �� 5�       � ��$ Center=�6K   �� 5�       � ��$ Center=�6I   �� 5�       � ��$ 30 0 0 0q�68   �� 5�       � �� 5�   "   �� 5�   &   "  66   .R�5�   *   �� $ 	10 10 0 0��5�   -   #��z��5�   -   #��z��5�   -   ._�5�   .   �� $��Center=�6?   $��Center=�6Z   5�   +   5�   '   5�       5�      5�      �� 5�      " ��6    .�5�      ��  � �� �#2638596;   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn    Header$	  №��6-   !   
IsReadOnly! . "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 80 6a   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 68   �� *id+6a     5�      $
  Nomi��6-   ! . $
" 200* 6h   # 6;   �� *client+6h     5�      $  O'lchov��6-   ! . $	" 100 6j   # 6>   �� *phone+6j     5�      $  Miqdor��6-   ! . $	" 100 6k   # 6=   �� *	address+6k     5�      $  Ishlab chiqaruvchi��6-   ! . $
" 150* 6{   # 6I   �� *cart_number+6{     5�      $  Yetkazib beruvchi��6-   ! . $
" 150* 6x   # 6H   �� *	bonus_sum+6x     5�      $  Valyuta��6-   ! . $	" 100 6q   # 6>   �� *bonus_dollar+6q     5�      $  Kelish narxi��6-   ! . $	" 100 6v   # 6C   �� *bonus_dollar+6v     5�      $  Mahsulot grupasi��6-   ! . $	" 150 6z   # 6G   �� *bonus_dollar+6z     5�      $  
Shtrix kod��6-   ! . $	" 150 6t   # 6A   �� *bonus_dollar+6t   5�      5�      5�      � 5�   
   $��2��6   $��Right=�6   $��	0 0 70 0 q�68   .+�5�      ��   btnSell#��[ 6   ���#012366$	��198��6K   $��44��6W   .��5�      �� $��Excelga export��6   $
��15px(�62   5�      5�      5�      5�      