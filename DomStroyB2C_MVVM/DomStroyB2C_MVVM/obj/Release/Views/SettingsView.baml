   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  )    #DomStroyB2C_MVVM.Views.SettingsView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources  ��%    .��� ���#E5E5E5 � RowDefinitions �� $��50 ��� $	��200 ��� $��* ��� $��20 �.+�� $��0�����#4D638C.+���    	txtSearch#��[  $	��524��$��34��$��Center=�$��Right=�$��0 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q�� $��1�� � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+��� $��0��  	btnHeader#��[ .����  �� Orientation$ 
Horizontal=�.+��� $��../Images/setting.png��$��56��$��56���� $��Check sozlamar��$��Center=�$��35 0 0 0q��� $��1��#��[ .���� $ 
Horizontal=�.+��� $��../Images/employeeAdd.png��$��56��$��56���� $��Hodim qo'shish��$��Center=�$��35 0 0 0q��� $��2��#��[ $��SeeEmployee������ *UpdateViewCommand+.���� $ 
Horizontal=�.+��� $ ��../Images/employeeList.png��$��56��$��56���� $��Hodimlar ro'yhati��$��Center=�$��35 0 0 0q��� $��3��$��../Images/line.png��$��	30 0 30 0q�$��Bottom=�$��Center=�$	��2px��� $��2��$��0 5 0 0q�.+��� -    ��Name$ scrollViewer��$��Disabled=�����  �� 
TargetType" �� �� Triggers ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid��	 �� Value		 False.a��� 
 �� Property
 � �� �� Value$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridEmployee��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2��$��
25 15 25 0q�    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� 
TargetType �� CornerRadius��%@  '        7  '  D     7  '  .    '  �    7  '�� �    �� "  8   .��� 
 �@ GridLinesVisibility$ 
Horizontal=��� "  8   .��� 
 �@�FocusVisualStyle Z� �� 
 � �� �#7A7979�� 
 � ��$ 0q��� 
 � ��$ 50���� 
 �@��TextAlignment$ Center=� P�  �@ 
IsSelected . . ��� 
 � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ��� 
 � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ��� 
 � �� �#E3E2E2�� "  8   .��� 
 � �� �#283654�� 
 � ��
 ������� 
 � ��$ 55���� 
 � ��$ Center=��� 
 � ��$ Center=��� 
 � ��$ 30 0 0 0q��� 
 � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.��� 
 � �� �#263859   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn    Header$  ID��!   
IsReadOnly! . "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 80 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� *id+  $	  Ism��! . $
" 200* # �� *
first_name+  $  Familiya��! . $
" 200* # �� *	last_name+  $  Lavozim��! . $
" 200* # �� *staff+4	  .System.Windows.Controls.DataGridTemplateColumn	    �� $��Olib tashlash��$	��150��
�������$��Segoe UI)�$��15(�$ �� TextAlignment$$ Center=�% 	  CellTemplate% �� .R���   	btnSearch#��[ $��60��$��40��$��0q�$��Center=�$��Center=�.���� $"��../Images/removeEmployee.png��$��25��$��25��