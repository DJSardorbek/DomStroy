   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  0    *DomStroyB2C_MVVM.Views.RepOtkazProductView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources   �� 
TargetType   txtText �� Property �� Value��%   &	        �� " ��.���  � ��
 �������  � ��$ Segoe UI)���  � ��$ Center=���  � ��$ Center=�.��� ���#E5E5E5 � RowDefinitions �� $��50 ��� $��* ��� $��80 �.+�� $��0�����#4D638C � ColumnDefinitions �� $
��Auto ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�.+��� $
��Sale������ *UpdateViewCommand+���� " ��.���  � ��$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30���� $"��Qaytarib olingan mahsulotlar��#��[  $
��20px(�$��30 0 0 0q�� $��1��.+���   	txtSearch#��[ $	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q�� $��1��$��0 20 0 0q�.+��� -    ��Name$ scrollViewer��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridClient��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2��$��	25 0 25 0q�    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� CornerRadius��%*  '        7  '  D     7  '      '  �    7  '�� �    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  �@��TextAlignment$ Center=� P� 	 �@ 
IsSelected
 . . ���  � �� �#4D638C�� "   P� 	 �@ AlternationIndex$
 0��. ���  � �� �#FFFFFFP� 	 �@ AlternationIndex$
 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn    Header$	  №��!   
IsReadOnly! . "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 80 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� *id+  $
  Nomi��! . $
" 200* # �� *client+  $  O'lchov��! . $	" 100 # �� *phone+  $  Miqdor��! . $	" 100 # �� *	address+  $  Ishlab chiqaruvchi��! . $
" 150* # �� *cart_number+  $  Yetkazib beruvchi��! . $
" 150* # �� *	bonus_sum+  $  Valyuta��! . $	" 100 # �� *bonus_dollar+  $  Kelish narxi��! . $	" 100 # �� *bonus_dollar+  $  Mahsulot grupasi��! . $	" 150 # �� *bonus_dollar+  $  
Shtrix kod��! . $	" 150 # �� *bonus_dollar+� $��2��$��Right=�$��	0 0 70 0 q�.+���   btnSell#��[ ���#012366$	��198��$��44��.���� $��Excelga export��$
��15px(�