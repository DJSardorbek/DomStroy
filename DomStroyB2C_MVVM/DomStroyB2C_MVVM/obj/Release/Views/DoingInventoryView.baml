   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  /    )DomStroyB2C_MVVM.Views.DoingInventoryView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views     .��� ���#EDEDED  � RowDefinitions  �� $��50 ��� $	��100 ��� $��* ��� $��20 �.+�� $��0�����#4D638C � ColumnDefinitions �� $	��320 ��� $��* �.+���  �� Orientation$ 
Horizontal=�.+��� $��	Inventory������ *UpdateViewCommand+����  �� 
TargetType" ��.���  �� Property � �� �� Value$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value	 . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30���� $��../Images/employee.png��$��27��$��27��$��20 0 0 0q��� 
 �� SelectedIndex$
 0��   ComboBoxTest1#��[  $	��180��$��35��$��10 0 0 0q�.@��� .���� $��Jahongir Karimov��� $��1�� �� $	��360 ��� $��* �.+��� $��0��$ 
Horizontal=�.+��� 
 � Tag$ Do'kon/Ombordan izlash...��  	txtSearch#��[ $	��300��$��35��$��Center=�$��Right=�$��0 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��
-600 0 0 0q���   btnNoneBorder#��[ $��50��$��	-10 0 0 0q�.���� $��../Images/refresh.png��$��40��$��40��� $��1�� �� $��* ��� $	��200 �.+�� $��0��$��Right=�$��0 0 20 0q�.+��� #��[ $ Ro'yhatdan izlash...��$	��300��$��35��$��Center=�$��Center=�$
��Auto��$��0 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��
-280 0 0 0q��� $��1��$ 
Horizontal=�.+��� #��[ $��50��$��MissedProducts������ *UpdateViewCommand+.���� $��../Images/checkList.png��$��40��$��40���� #��[ $��50��.���� $!��../Images/stopInventory.png��$��40��$��40���� #��[ $��50��.���� .+��� $!��../Images/editInventory.png��$��40��$��30���� $"��../Images/editInventory1.png��$��40��$��10��� $��1��$��	20 13 0 0q� �� $��* ��� $��* ��� $��* �.+��� $��0��.+��� $ 
Horizontal=�$��Center=�$��Center=�.+���  �� CornerRadius$ 5 0 0 0��$	��140��$��36��$��Center=����#4D638C�� $��
Summa so'm��$��-150 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��18(�
��������� $	��240��$��36��$��	1 000 000��.������ " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . �� -  'System.Windows.Input.KeyboardNavigation �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 130����  � ��$ 31����  �@J�	AllowDrop . ��  � �� �#009BDE��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#009BDE��  � ��$ SemiBold"���  � �� �� " ��.R��� $��Border��$ 0 5 0 0�� �� Padding$ 	10 5 10 5q�$��1q�����  �� Color$ #FFFFFF������ $ #C4C4C4��._���  ��Name$ PART_ContentHost��$��0q�.���� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ 0 0 0 5��$	��140��$��36��$��Center=����#4D638C�� $��Summa dollar��$��-140 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��18(�
��������� $	��240��$��36��$	��100��.������ " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 130����  � ��$ 31����  �@J�	AllowDrop . ��  � �� �#009BDE��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#009BDE��  � ��$ SemiBold"���  � �� �� " ��.R��� $��Border��$ 0 0 5 0��$ 	10 5 10 5q�$��1q����� $ #FFFFFF������ $ #C4C4C4��._��� $ PART_ContentHost��$��0q�.���� $��1��.+��� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ 5 0 0 0��$	��140��$��36��$��Center=����#4D638C�� $��Omborda so'm��$��-150 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��18(�
��������� $	��240��$��36��$��	1 000 000��.������ " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 130����  � ��$ 31����  �@J�	AllowDrop . ��  � �� �#92DA71��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#92DA71��  � ��$ SemiBold"���  � �� �� " ��.R��� $��Border��$ 0 5 0 0��$ 	10 5 10 5q�$��1q����� $ #FFFFFF������ $ #C4C4C4��._��� $ PART_ContentHost��$��0q�.���� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ 0 0 0 5��$	��140��$��36��$��Center=����#4D638C�� $��Omborda dollar��$��-140 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��18(�
��������� $	��240��$��36��$	��100��.������ " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 130����  � ��$ 31����  �@J�	AllowDrop . ��  � �� �#92DA71��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#92DA71��  � ��$ SemiBold"���  � �� �� " ��.R��� $��Border��$ 0 0 5 0��$ 	10 5 10 5q�$��1q����� $ #FFFFFF������ $ #C4C4C4��._��� $ PART_ContentHost��$��0q�.���� $��2��.+��� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ 5 0 0 0��$	��140��$��36��$��Center=����#4D638C�� $��Kamomad so'm��$��-150 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��18(�
��������� $	��240��$��36��$��	1 000 000��.������ " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 130����  � ��$ 31����  �@J�	AllowDrop . ��  � �� �#F57070��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#F57070��  � ��$ SemiBold"���  � �� �� " ��.R��� $��Border��$ 0 5 0 0��$ 	10 5 10 5q�$��1q����� $ #FFFFFF������ $ #C4C4C4��._��� $ PART_ContentHost��$��0q�.���� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ 0 0 0 5��$	��140��$��36��$��Center=����#4D638C�� $��Kamomad dollar��$��-140 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��18(�
��������� $	��240��$��36��$	��100��.������ " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 130����  � ��$ 31����  �@J�	AllowDrop . ��  � �� �#F57070��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#F57070��  � ��$ SemiBold"���  � �� �� " ��.R��� $��Border��$ 0 0 5 0��$ 	10 5 10 5q�$��1q����� $ #FFFFFF������ $ #C4C4C4��._��� $ PART_ContentHost��$��0q�.��� $��2��$��0 5 0 0q�.+��� -   $ scrollViewer��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridDoingInventory��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=�  �� AlternationCount$  2��$��	20 0 20 0q�! � 	Resources!   MaterialDesignDataGrid" �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%*  '        7  '  D     7  '      '  �    7  '�� �    �� "  8"   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8"   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  �@��TextAlignment$ Center=� P�  �@ 
IsSelected	 . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$	 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$	 1��. ���  � �� �#E3E2E2�� "  8"   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859#   Columns# 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn$   Header$$ Chek ID��%   
IsReadOnly% . &   Width5  /System.Windows.Controls.DataGridLengthConverter$& 80 1	  +System.Windows.Controls.DataGridBoundColumn' 	  Binding' �� *id+  $
$ Nomi��% . $
& 150* ' �� *name+  $$ Ishlab chiqaruvchi��% . $
& 150* ' �� *
preparer+  $$ Tekshiruvchi��% . $
& 150* ' �� *	checker+4
  .System.Windows.Controls.DataGridTemplateColumn
  $ � $	��200��  �� $��* ��� $��* �.+��� $��1q����#909DBA$��27��._�� $��0��.+��� $��Hujjatda��( �� TextAlignment$( Center=�� $��1��$��27�� �� �� .+��� $��0��$��1 0 1 1 q����#909DBA$��25��._��� $��
O'lchov b.��$( Center=��� $��1��$��0 0 1 1 q����#909DBA$��25��._��� $��Miqdori��$( Center=�) 
  CellTemplate) �� .R��  �� �� .+�� $��0��.+��� ���#009BDE$��Segoe UI)�$
��13px(�$( Center=����� *measurement+� $��1��.+��� ���#009BDE$��Segoe UI)�$
��13px(�$( Center=����� *
app_quan+
  $ � $	��200��  �� $��* ��� $��* �.+��� $��0 1 1 1q����#909DBA$��27��._�� $��0��.+��� $��Omborda��$( Center=�� $��1��$��27�� �� �� .+��� $��0��$��0 0 1 1 q����#909DBA$��25��._��� $��
O'lchov b.��$( Center=��� $��1��$��0 0 1 1 q����#909DBA$��25��._��� $��Miqdori��$( Center=�) �� .R��  �� �� .+�� $��0��.+��� ���#92DA71$��Segoe UI)�$
��13px(�$( Center=����� *measurement+� $��1��.+��� ���#92DA71$��Segoe UI)�$
��13px(�$( Center=����� *
store_quan+
  $ � $	��200��  �� $��* ��� $��* �.+��� $��0 1 1 1q����#909DBA$��27��._�� $��0��.+��� $��Farqi��$( Center=�� $��1��$��27�� �� �� .+��� $��0��$��0 0 1 1 q����#909DBA$��25��._��� $��
O'lchov b.��$( Center=��� $��1��$��0 0 1 1 q����#909DBA$��25��._��� $��Miqdori��$( Center=�) �� .R��  �� �� .+�� $��0��.+��� ���#F57070$��Segoe UI)�$
��13px(�$( Center=����� *measurement+� $��1��.+��� ���#F57070$��Segoe UI)�$
��13px(�$( Center=����� *	diff_quan+  $$ Yaroqlilik Muddati��% . $
& 150* ' �� *	last_date+  $$ 
Farq summa��% . $
& 150* ' �� *
diff_summa+* 	  ElementStyle* �� " ��.���  � ��
 �  ��