   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  K GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views *   $DomStroyB2C_MVVM.Views.ChashDeskView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     6local$clr-namespace:DomStroyB2C_MVVM.Views     .��� ���#E5E5E5  � RowDefinitions  �� $��50 ��� $��* �.+�� $��0�����#4D638C.+��� -   $	��200��$
��Left=�$��Print���� -    ��Name$ 	txtSearch��
 � Tag$ 	Izlash...��   	txtSearch#��[  $	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q�.���� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q�� $��1��.+��� -    ��Name$ scrollViewer��$��Disabled=�����  �� 
TargetType" �� �� Triggers ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a��� 	 �� Property	 � ��
 �� Value$

 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridCash��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��20q�$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2������  �� Path$ ShopList� �� Mode$ TwoWay=� �� SelectedItem �� $
 Shop�$ TwoWay=� � 	Resources   MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader  �� 
TargetType! �� CornerRadius��%Z  '        7  '  D     7  '  H    '  �    7  '�� �    �� "  8   .��� 	 �@ GridLinesVisibility$
 
Horizontal=��� "  8   .��� 	 �@�FocusVisualStyle
 Z� �� 	 � ��
 �#7A7979�� 	 � ��$
 0q��� 	 � ��$
 50���� 	 �@��TextAlignment$
 Center=��� 	 � ��$
 Center=� P�  �@ 
IsSelected . . ��� 	 � ��
 �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ��� 	 � ��
 �#FFFFFFP�  �@ AlternationIndex$ 1��. ��� 	 � ��
 �#E3E2E2�� "  8   .��� 	 � ��
 �#283654�� 	 � ��

 ������� 	 � ��$
 55���� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��$
 30 0 0 0q��� 	 � ��
 �� "   .R��� $! 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.��� 	 � ��
 �#263859"   Columns" 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn#   Header$
# Chek��$   
IsReadOnly$ . %   Width5  /System.Windows.Controls.DataGridLengthConverter$% 80 1  +System.Windows.Controls.DataGridBoundColumn&   Binding& �� *Id+  $
# Izoh��$ . $
% 150* & �� *	Comment+  $# Sotuvchi��$ . $
% 150* & �� *Seller+  $# 
Summa so'm��$ . $	% 150 & �� *SumSom+  $# Summ dollar��$ . $	% 150 & �� *	SumDollar+  $
# Sana��$ . $
% 150* & �� *Date+4	  .System.Windows.Controls.DataGridTemplateColumn	  # �� $��To'lov��$
��120 ��
�������$��Segoe UI)�$��15(�' �� TextAlignment$' Center=�( 	  CellTemplate( �� .R���   btnPlus#��[ $	��100��.
   (System.Windows.Interactivity.Interaction) 
  Triggers) /   )System.Windows.Interactivity.EventTrigger  *   	EventName$* Click��.   (System.Windows.Interactivity.TriggerBase+   Actions.+ 6   0System.Windows.Interactivity.InvokeCommandAction  ,   Command, �� - �� RelativeSource- �� . �� AncestorType". >�$$ DataContext.OpenPaymentCommand�.���� $��../Images/Pay.png��$��20��$��20��	  # �� $��Bekor qilish��$
��120 ��
�������$��Segoe UI)�$��15(�$' Center=�( �� .R���   	btnCancel#��[ $	��100������ - �� ". >�$# DataContext.CancelShopCommand�.���� $!��../Images/cancelRecieve.png��$��20��$��20��