   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  *    $DomStroyB2C_MVVM.Views.InventoryView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views     .��� ���#EDEDED  � RowDefinitions  �� $��50 ��� $��* ��� $��20 �.+�� $��0�����#4D638C � ColumnDefinitions �� $	��280 ��� $	��280 ��� $��* �.+���  �� Orientation$ 
Horizontal=�.+��� $��../Images/employee.png��$��27��$��27��$��50 0 0 0q��� $��Jahongir Karimov��
�������$��Center=�$
��20px(�$��15 0 0 0q�� $��1��.+���    ComboBoxTest2#��[  $	��250��$��35���� $ 
Horizontal=�$��2��.+���   btnNoneBorder#��[ $��DoingInventory������ *UpdateViewCommand+.���� $ 
Horizontal=�.+��� $��../Images/png.png��$��35��$��28���� $��Tekshiruv yaratish��
�������$��Center=�$
��20px(�$��10 0 0 0q�� $��1��$��0 5 0 0q�.+��� -    ��Name$ scrollViewer��$��Disabled=�����  �� 
TargetType" �� �� Triggers ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a��� 	 �� Property	 � ��
 �� Value$

 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridInventory��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2��$��
20 20 20 0q� � 	Resources   MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� 
TargetType �� CornerRadius��%*  '        7  '  D     7  '      '  �    7  '�� �    �� "  8   .��� 	 �@ GridLinesVisibility$
 
Horizontal=��� "  8   .��� 	 �@�FocusVisualStyle
 Z� �� 	 � ��
 �#7A7979�� 	 � ��$
 0q��� 	 �@��TextAlignment$
 Center=� P�  �@ 
IsSelected . . ��� 	 � ��
 �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ��� 	 � ��
 �#FFFFFFP�  �@ AlternationIndex$ 1��. ��� 	 � ��
 �#E3E2E2�� "  8   .��� 	 � ��
 �#283654�� 	 � ��

 ������� 	 � ��$
 55���� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��$
 30 0 0 0q��� 	 � ��
 �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.��� 	 � ��
 �#263859   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn    Header$	  №��!   
IsReadOnly! . "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 80 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� *id+  $  Filial��! . $
" 200* # �� *branch+  $
  Sana��! . $
" 150* # �� *date+  $  Eski qoldiq��! . $
" 120* # �� *
old_qaun+  $  Yangi qoldiq��! . $
" 120* # �� *
new_quan+  $  Farq so'mda��! . $	" 150 # �� *
diff_som+  $  Farq dollarda��! . $	" 150 # �� *diff_dollar+  $  Tekshiruvchi��! . $
" 150* # �� *	checker+  $  Holati��! . $
" 150* # �� *	condition+