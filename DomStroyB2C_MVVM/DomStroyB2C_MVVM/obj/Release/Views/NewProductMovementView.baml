   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  3    -DomStroyB2C_MVVM.Views.NewProductMovementView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources   �� 
TargetType �� Property �� Value��%e   '��       �� " ��.���  � ��$ Center=���  � ��$ Segoe UI)���  � ��$
 15px(�.��� ���#E5E5E5 � RowDefinitions �� $��50 ��� $
��Auto ��� $��80 ��� $��* ��� $��20 �.+�� $��0�����#4D638C.+��� $��RecieveFaktura������ *UpdateViewCommand+���� " ��.���  � ��$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30����    	txtSearch#��[  $	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q�� -   	 �Name$	 
GridSearch��$��1��$	��405��$
��1000��$y�Visible=�$��Right=�$��0 9 25 0q����#FFFFFF
 K� ZIndex$
 1��.+��� -    ��Name$ scrollViewer1��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridProduct��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .  ���#FFFFFF$��1q����#C0C0C0   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2�� �� SelectedItem ��  �� Path$ Product�  �� Mode$  TwoWay=����� $ ProductList�$  TwoWay=�! J� InputBindings! �� 
" �� Key$" Enter��# �� Command# �� *
MoveBasket+    MaterialDesignDataGrid$ �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%�  '        7  '  D     7  '  ,    '  �    7  '�� �    �� "  8$   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8$   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 38����  �@��TextAlignment$
 Left=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "  .���  �@��TextAlignment$ Center=� P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8$   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$
 Left=���  � ��$ Center=� �� " ��.���  � �� �#263859%   Columns% 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn&   Header$	& Kod��'   
IsReadOnly' . (   Width5  /System.Windows.Controls.DataGridLengthConverter$( 80 1  +System.Windows.Controls.DataGridBoundColumn)   Binding) �� $ 
Product_id�  $& Maxsulot nomi��' . $
( 110* ) �� $
 Name�  $& Ishlab chiqaruvchi��' . $	( 140 ) �� $ Producer�  $& O'lchov��' . $( 77 ) �� $ Measurement�  $& Miqdori��' . $	( 103 ) �� $ Amount�  $& Narxi��' . $	( 110 ) �� $ Selling_price�  $& Valyuta��' . $( 76 ) �� $ Currency�  $& Guruh��' . $( 80 ) �� $ Category�  $
& Ball��' . $( 54 ) �� $
 Ball�� $��2��$	��Top=�$��
0 -400 0 0q�* � ColumnDefinitions* �� $��* ��� $	��300 �.+��� + �� Orientation$+ 
Horizontal=�$��0��.+��� $��Faktura № 75��$��50 0 0 0q��� $2��,Elktrotovarlarni Andijon filialga ko'chirish��$��30 0 0 0q�� $��1��.+���   btnSell#��[ $	��205��$��42��.���� $+ 
Horizontal=�.+��� $��Saqlash��$
��15px(�$��65 0 0 0q��� $��../Images/save.png��$��18��$��18��$��40 0 0 0q�� $��3��$��
0 -425 0 0q�.+��� -   $ scrollViewer��$��Disabled=����� " �� ��  �� *
HasItems+$ dataGrid��	 False.a���  � ��$
 Auto=�.��  -   $ dataGridBasket��$y�Visible=�$
 Auto=�$
��Auto�� �#E3E2E2 .  $ 
Horizontal=� .   .   .   .   .   .  ���#FFFFFF$��10q�$��1q�$ Single=�$ FullRow=�$ 2��  , �� CornerRadius��%Z  '        7  '  D     7  '  H    '  �    7  '�� �    �� "  8$   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8$   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=���  � ��$ Center=� P�  �@ 
IsSelected . . ���  � �� �#4D638C�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8$   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $, 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859%   $	& №��' . $( 80 ) �� *id+  $& Mahsulot nomi��' . $
( 150* ) �� *name+  $& 
Shtrix kod��' . $	( 100 ) �� *measurement+  $& Ishlab chiqaruvchi��' . $
( 150* ) �� *name+  $& Yetkazib beruvchi��' . $
( 150* ) �� *name+  $& Valyuta��' . $	( 100 ) �� *	valyuta+  $& Sotish narxi��' . $	( 150 ) �� *price+  $& Miqdor��' . $	( 150 ) �� *price+  $& Mahsulot guruhi��' . $
( 100* ) �� *summa+  $& Umumiy summa��' . $
( 150* ) �� *summa+