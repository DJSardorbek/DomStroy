   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  K GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views %   DomStroyB2C_MVVM.Views.SaleView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  0local$clr-namespace:DomStroyB2C_MVVM.Views  -     � 	Resources   �� 
TargetType �� Property �� Value   	txtAmount-  'System.Windows.Input.KeyboardNavigation �� 
TargetType �� CornerRadius �� Padding �� Color ��Name	 �� Triggers
 P� Property P� Value��%�  '��       &	  ]     �� " ��.���  � ��$ Segoe UI)���  � ��$
 13px(���  � �� �#909090�� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 100����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �#636262��  � ��$ Segoe UI)���  � ��$
 15px(���  �@��
CaretBrush �#636262��  � ��
 ���� ��  �@��
IsReadOnly . ��  � �� �� " ��.R��� $��Border��$ 0��$ 5q�$��0q�#��z������ $ #FFFFFF��._��� $ PART_ContentHost��$��0q�	 P� 
 �@J�	IsFocused . . ���  �@��
IsReadOnly .  ��  � ��
 �����.��� ���#E5E5E5 � RowDefinitions �� $��50 ��� $
��Auto ��� $��70 ��� $��* ��� $��80 �.+�� $��0�����#4D638C.+��� -    ��Name$ 	txtSearch��
 � Tag$ 	Izlash...��  	txtSearch#��[ $	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q�.������  �� Path$ Search� �� UpdateSourceTrigger$ PropertyChanged=�.��.   (System.Windows.Interactivity.Interaction   Triggers /   )System.Windows.Interactivity.EventTrigger     	EventName$ TextChanged��.   (System.Windows.Interactivity.TriggerBase   Actions. 6   0System.Windows.Interactivity.InvokeCommandAction     Command �� *SearchCommand+.���� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q��� -   |�.  .���� $��../Images/filter.png��$��20��$��20��$��Center=�$��Center=����� " ��.���  � ��$ 25����  � ��$ 25����  � ��$ Right=���  � ��$ 	0 0 544 0q���  � ��
 �������  � ��
 �������  � �� �� " ��.R��� #��z��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ���  � ��
 ������ -    �Name$ 
GridSearch��$��1��$	��405��$
��1000��$��Right=�$��0 9 25 0q����#FFFFFF K� ZIndex$ 1��y��� *ProductGridVisibility+.+��� -   $ scrollViewer1��$��Disabled=����� " ��	 ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridProduct��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .      CanUserDeleteRows  .  !   
IsReadOnly! .  "   CanUserReorderColumns" .  #   CanUserResizeColumns# .  $   CanUserResizeRows$ .  %   CanUserSortColumns% .  ���#FFFFFF$��1q����#C0C0C0&   SelectionMode$& Single=�'   SelectionUnit$' FullRow=�( �� AlternationCount$( 2��) �� SelectedItem) �� $ Product�* �� Mode$* TwoWay=����� $ ProductList�$* TwoWay=�+ J� InputBindings+ �� 
, �� Key$, Enter��- �� Command- �� *
MoveBasket+    MaterialDesignDataGrid. �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=	  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%�  '        7  '  D     7  '  ,    '	  �    7  '�� �    �� "  8.   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8.   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 38����  �@��TextAlignment$
 Left=�	 P� 
 �@ 
IsSelected . . ���  � �� �#B6E0FF�� "  .���  �@��TextAlignment$ Center=�	 P� 
 �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP� 
 �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� " 	 8.   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$
 Left=���  � ��$ Center=�	 �� " ��.���  � �� �#263859/   Columns/ 0
  *System.Windows.Controls.DataGridTextColumn
  ,  &System.Windows.Controls.DataGridColumn0   Header$	0 Kod��1   
IsReadOnly1 . 2   Width5  /System.Windows.Controls.DataGridLengthConverter$2 80 1  +System.Windows.Controls.DataGridBoundColumn3   Binding3 �� $ 
Product_id�
  $0 Maxsulot nomi��1 . $
2 110* 3 �� $
 Name�
  $0 Ishlab chiqaruvchi��1 . $	2 140 3 �� $ Producer�
  $0 O'lchov��1 . $2 77 3 �� $ Measurement�
  $0 Miqdori��1 . $	2 103 3 �� $ Amount�
  $0 Narxi��1 . $	2 110 3 �� $ Selling_price�
  $0 Valyuta��1 . $2 76 3 �� $ Currency�
  $0 Guruh��1 . $2 80 3 �� $ Category�
  $
0 Ball��1 . $2 54 3 �� $
 Ball�� $��2��$	��Top=�$��
0 -394 0 0q�4 � ColumnDefinitions4 �� $
��Auto ��� $��* �.+�� $��1��$��Right=�$��0 0 25 0q�.+�� $��1��$��Right=�.+��� 5 �� Orientation$5 
Horizontal=�.+��� $5 
Horizontal=�$��Center=�$��Center=�.+��� $ 5 0 0 5��$	��120��$��36��$��Center=����#4D638C�� $��Umumiy so'm��$��-120 -5 0 0q�$��Center=�$��Center=�$��Segoe UI)�$��15(�
���������   txtKurs#��[ $	��180��$��36��$��0 0 28 0q�6 �� 
IsReadOnly6 . ���� $ SumSom�$* OneWay=��� $5 
Horizontal=�$��Center=�$��Center=�� $��3��$��
0 -409 0 0q�.+��� -   $ scrollViewer��$��Disabled=����� " ��	 ��  �� *
HasItems+$ dataGrid��	 False.a���  � ��$
 Auto=�.��  -   $ dataGridBasket��$y�Visible=�$
 Auto=�$
��Auto�� �#E3E2E2 .  $ 
Horizontal=� .    .  ! .  " .  # .  $ .  ���#FFFFFF$��	26 0 26 0q�$��1q�$& Single=�$' FullRow=�$( 2������ $ 
BasketList�$* TwoWay=�) �� $ Basket�$* TwoWay=�+ �� $, Delete��- �� *DeleteCartCommand+  ��%I  '        7  '  D     7  '  F    '	  �    7  '�� �    �� "  8.   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8.   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 46����  � ��$ Center=���  �@��TextAlignment$
 Left=�	 P� 
 �@ 
IsSelected . . ���  � �� �#B6E0FF�� "  	 P� 
 �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP� 
 �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� " 	 8.   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � �� �� " 	 .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$
��Left=�$��15 0 0 0q�	 �� " ��.���  � �� �#263859/ 
  $	0 Kod��1 . $2 80 3 �� *	Product+
  $0 Maxsulot nomi��1 . $
2 150* 3 �� *Name+
  $0 Ishlab chiqaruvchi��1 . $
2 200* 3 �� *
Producer+
  $0 O'lchov��1 . $	2 90* 3 �� *Measurement+4  .System.Windows.Controls.DataGridTemplateColumn  0 �� $��Miqdori��$	��120��7 �� TextAlignment$7 Center=�
�������8   CellTemplate8 �� .R��� #��[  $	��120��9 �� TextAlignment$9 Center=�.��+ �� $, Return��- �� : �� RelativeSource: �� ; �� AncestorType"; >�$* $DataContext.UpdateCartProductCommand�.������ $ Amount�$ PropertyChanged=�.��   $ TextChanged��.    �� : �� "; >�$ DataContext.Show�.��.��
  $0 Narxi��1 . $
2 120* 3 �� *Selling_price+
  $0 Valyuta��1 . $	2 80* 3 �� *
Currency+
  $0 Summa��1 . $	2 150 3 �� *Sum+� $��4��$��Bottom=�.+�]� $��Bottom=�$��Right=�$��0 -414 25 10q�.+�� 4 �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+�� $��0��$��0 0 20 0q�.+���   btnSell#��[ ���� *CancelShopCommand+.���� $5 
Horizontal=�$	��230��.+��� $��../Images/SellCancel.png��$��33��$��33��$��25 0 0 0q��� $��Bekor qilish��$
��18px(����#FFFFFF$��Center=�$7 Center=�$��29 0 0 0q�� $��1��$��0 0 20 0q�.+��� -	   #��[ ���� *SeperateShopCommand+.���� $5 
Horizontal=�$	��230��.+��� $��../Images/SellCash1.png��$��33��$��33��$��25 0 0 0q��� $��Kassa��$
��18px(����#FFFFFF$��Center=�$7 Center=�$��30 0 0 0q�� $��2��$��0 0 20 0q�.+��� #��[ $��ClientOrder������ *MoveOrderCommand+.���� $5 
Horizontal=�$	��230��.+��� $��../Images/SellBook.png��$��33��$��33��$��25 0 0 0q��� $��Buyurtma olish��$
��18px(����#FFFFFF$��Center=�$7 Center=�$��15 0 0 0q�� $��3��$��0 0 20 0q�.+��� #��[ ���� *
MoveBasket+.���� $5 
Horizontal=�$	��230��.+��� $��../Images/SellCart.png��$��33��$��33��$��25 0 0 0q��� $��Korzinkaga olish��$
��18px(����#FFFFFF$��Center=�$7 Center=�$��15 0 0 0q�� $��4��.+��� #��[ ���� *MoveQueueCommand+.���� $5 
Horizontal=�$	��230��.+��� $��../Images/SellQueue.png��$��33��$��33��$��25 0 0 0q��� $��Navbatga olish��$
��18px(����#FFFFFF$��Center=�$7 Center=�$��15 0 0 0q�