   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  ,    &DomStroyB2C_MVVM.Views.SeeEmployeeView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources   �� 
TargetType   txtInfor �� Property �� Value��%�   &	        �� " ��.���  � ��$ Segoe UI)���  � ��$
 22px(���  � ��$ SemiBold"���  � ��$ Center=���  � ��$ 20 0 0 0q�.��� ���#E5E5E5 � RowDefinitions �� $��50 ��� $	��300 ��� $��80 ��� $��* ��� $��20 �.+�� ���#4D638C.+��� $��Settings������ *UpdateViewCommand+���� " ��.���  � ��$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30��� $��1��	 � ColumnDefinitions	 �� $	��320 ��� $��* �.+��� $	��290��$	��280��$��1q�$��0 20 0 0q����#283654
 �� CornerRadius$
 8��._��  �� $��* ��� $��60 �.+��� $��0��$"��../Images/bigEmployeeAdd.png��$	��180��$	��135���� $��1�� �� Orientation$ 
Horizontal=�.+��� $��Umarjon Maxkamov��
�������$��Segoe UI)�$
��18px(�$��Center=�$
��Left=�$��20 0 0 0q�$	��180��� $��20 0 0 0q�.+��� -    ��Name$
 Back�����	#FFADABAD$
��Left=�$��21��$��Center=�$��50�� �� RadiusX$ 10�� �� RadiusY$ 10��A� -    A�Name$	 Dot��$��Center=�$��15.89��$��Center=�$��15.89�����#4D638C$��0q��� $��1��$
 8��$��1q�
�������$	��280��$��
20 20 20 0q�._��  �� $��40 ��� $��33 ��� $��33 ��� $��33 ��� $��33 ��� $��33 ��� $��33 ��� $��40 �.+��� $��1��$ 
Horizontal=�.+��� #��[  $��Ismi : ��$��45,0,0,0q��� #��[  $��Umarjon���� $��2��$ 
Horizontal=�.+��� #��[  $��Familiyasi : ��$��45,0,0,0q��� #��[  $��Maxkamov���� $��3��$ 
Horizontal=�.+��� #��[  $��Telefon raqami : ��$��45,0,0,0q��� #��[  $��+998 99 603-16-18���� $��4��$ 
Horizontal=�.+��� #��[  $��Login : ��$��45,0,0,0q��� #��[  $��Umarjon@live.net���� $��5��$ 
Horizontal=�.+��� #��[  $��Parol : ��$��45,0,0,0q��� #��[  $
��3225���� $��6��$ 
Horizontal=�.+��� #��[  $��	Holati : ��$��45,0,0,0q��� #��[  $��aktiv��� $��2��	 �� �� $	��270 �.+�� .+���   	txtSearch#��[ $	��524��$��38��$��Center=�$��Center=�$��
270 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��Center=�$��
770 0 35 0q��� $��1��  btnSell#��[ $��243px��$
��40px��$��0 0 20 0q�.���� $ 
Horizontal=�.+��� $"��../Images/bigemployeeAdd.png��$��32��$��24��$��	-20 0 0 0q��� $��Hodim qo'shish��$
��18px(�$��28 0 0 0q�� $��3��$��0 5 0 0q�.+��� -    ��Name$ scrollViewer��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridEmployee��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�    SelectionUnit$  FullRow=�! �� AlternationCount$! 2��$��	25 0 25 0q�    MaterialDesignDataGrid" �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%@  '        7  '  D     7  '  .    '  �    7  '�� �    �� "  8"   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8"   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8"   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $
 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859#   Columns# 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn$   Header$	$ №��%   
IsReadOnly% . &   Width5  /System.Windows.Controls.DataGridLengthConverter$& 80 1  +System.Windows.Controls.DataGridBoundColumn'   Binding' �� *id+  $	$ Ism��% . $
& 150* ' �� *
first_name+  $$ Familiya��% . $
& 150* ' �� *	last_name+  $$ Lavozim��% . $
& 150* ' �� *staff+  $$ Login��% . $
& 150* ' �� *staff+4	  .System.Windows.Controls.DataGridTemplateColumn	  $ �� $	��150��$��Parol��( �� TextAlignment$( Center=�) 	  CellTemplate) �� .R��� ���� *
password+  $$ Telefon raqami��% . $
& 150* ' �� *staff+  $$ 	Aktivligi��% . $
& 150* ' �� *staff+