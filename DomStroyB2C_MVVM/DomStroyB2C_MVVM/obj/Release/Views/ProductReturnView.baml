   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  .    (DomStroyB2C_MVVM.Views.ProductReturnView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources   �� 
TargetType �� Property �� Value��%g   '��       �� " ��.���  � ��$ Segoe UI)���  � ��$
 13px(���  � �� �#909090.��� ���#E5E5E5 � RowDefinitions �� $��50 ��� $
��Auto ��� $	��120 ��� $��* ��� $��30 �.+�� $��0�����#4D638C.+��� -    ��Name$ 	txtSearch��
 � Tag$ 	Izlash...��   	txtSearch#��[  $	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q�.���� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q��� .���� $��../Images/filter.png��$��20��$��20��$��Center=�$��Center=����� " ��.���  � ��$ 25����  � ��$ 25����  � ��$ Right=���  � ��$ 	0 0 544 0q���  � ��
 �������  � ��
 �������  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  � ��
 ������ -    �Name$ 
GridSearch��$��1��$	��405��$	��905��$y�Hidden=�$��Right=�$��0 9 25 0q����#FFFFFF K� ZIndex$ 1��.+��� -    ��Name$ scrollViewer1��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridProduct��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q����#C0C0C0   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2��    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%�  '        7  '  D     7  '      '  �    7  '�� `    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  �@��TextAlignment$ Center=� P� 	 �@ 
IsSelected
 . . ���  � �� �#B6E0FF�� "   P� 	 �@ AlternationIndex$
 0��. ���  � �� �#FFFFFFP� 	 �@ AlternationIndex$
 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q� �� " ��.���  � �� �#263859    Columns  0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn!   Header$! Maxsulot nomi��"   
IsReadOnly" . #   Width5  /System.Windows.Controls.DataGridLengthConverter$
# 200* 1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ �� *name+  $! Ishlab chiqaruvchi��" . $	# 150 $ �� *
preparer+  $! O'lchov birligi��" . $	# 120 $ �� *measurement+  $! Omborda��" . $	# 120 $ �� *
quantity+  $! Sotish narxi��" . $	# 120 $ �� *price+  $! Valyuta��" . $# 80 $ �� *	valyuta+  $! Guruh��" . $	# 100 $ �� *group+4	  .System.Windows.Controls.DataGridTemplateColumn	  ! �� � $��2��$	��Top=�$��
0 -404 0 0q�.+�� $
��Left=�$��30 0 0 0q�.+��� % �� Orientation$% 
Horizontal=�.+��� .+��� $��Hodim�����#000000$��Segoe UI)�$
��12px(�$��Center=�$
��Left=�$��SemiBold"�$��	20 10 0 0q��� $��0��$	��250��$��35��  ComboBoxTest2#��[ $
��Left=�$��	20 10 0 0q��� $% 
Horizontal=�$��	20 36 0 0q�.+��� 
�������& �� CornerRadius$& 3�����#C0C0C0$��1q�$	��150��$��35��._�(
  "System.Windows.Controls.DatePicker
  ���#C4C4C4$	��140��$��30���� $	��dan�����#000000$��Segoe UI)�$
��12px(�$��Center=�$
��Left=�$��SemiBold"�$��10 0 0 0q��� $% 
Horizontal=�$��	20 36 0 0q�.+��� 
�������$& 3�����#C0C0C0$��1q�$	��150��$��35��._�
  ���#C4C4C4$	��140��$��30���� $��gacha�����#000000$��Segoe UI)�$
��12px(�$��Center=�$
��Left=�$��SemiBold"�$��10 0 0 0q��� $��Bottom=�$��36 0 0 0q�.+���   btnSell#��[ $��42��$	��205��.���� $��
Filterlash��
�������$
��15px(�� $��3��$��
0 -429 0 0q�.+��� -   $ scrollViewer��$��Disabled=����� " �� ��  �� *
HasItems+$ dataGrid��	 False.a���  � ��$
 Auto=�.��  -   $ dataGridBasket��$y�Visible=�$
 Auto=�$
��Auto�� �#E3E2E2 .  $ 
Horizontal=� .   .   .   .   .   .  ���#FFFFFF$��	26 0 26 0q�$��1q�$ Single=�$ FullRow=�$ 2��  ��%Z  '        7  '  D     7  '  H    '  �    7  '�� �    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=���  � ��$ Center=� P� 	 �@ 
IsSelected
 . . ���  � �� �#B6E0FF�� "   P� 	 �@ AlternationIndex$
 0��. ���  � �� �#FFFFFFP� 	 �@ AlternationIndex$
 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $& 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859    $! Chek ID��" . $# 80 $ �� *id+  $! Hodim��" . $
# 150* $ �� *name+  $! Mijoz��" . $
# 150* $ �� *name+  $! 	Jami so'm��" . $	# 130 $ �� *measurement+  $! Jami dollar��" . $	# 130 $ �� *
quantity+  $! Nasita so'm��$	# 130 " . $ �� *price+  $! Nasiya dollar��" . $	# 130 $ �� *	valyuta+  $
! Sana��" . $
# 200* $ �� *summa+	  ! �� 