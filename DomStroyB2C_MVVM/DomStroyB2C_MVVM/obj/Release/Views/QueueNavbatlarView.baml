   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  /    )DomStroyB2C_MVVM.Views.QueueNavbatlarView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  0local$clr-namespace:DomStroyB2C_MVVM.Views  .��� ���#EDEDED.+��� -     ��Name$  scrollViewer��$��Disabled=�����  �� 
TargetType" �� �� Triggers ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  �� Property � �� �� Value$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridQueue��$y�Visible=�$	   HorizontalScrollBarVisibility$
	 Auto=�$
��Auto��
   HorizontalGridLinesBrush
 �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��
0 10 10 10q�$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2�� �� SelectedItem ��  �� Path$ Queue� �� Mode$ TwoWay=����� $ 	QueueList�$ TwoWay=� � 	Resources    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� 
TargetType �� CornerRadius��%Z  '        7   '  D     7  '  H    '  �    7  '�� �    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=���  � ��$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn    Header$
  Chek��!   
IsReadOnly! . "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 80 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� *Chek+  $
  Izoh��! . $
" 150* # �� *	Comment+  $  Sotuvchi��! . $
" 100* # �� *Seller+  $  Summa somda��! . $
" 100* # �� *Sum+  $  Summa dollarda��! . $
" 120* # �� *Dollar+  $
  Sana��! . $
" 150* # �� *Date+4	  .System.Windows.Controls.DataGridTemplateColumn	    �� $��Sotuvga olish��$
��120 ��
�������$��Segoe UI)�$��15(�$ �� TextAlignment$$ Center=�% 	  CellTemplate% �� .R���   btnPlus#��[ $��60��.
  (System.Windows.Interactivity.Interaction& 
  Triggers& /  )System.Windows.Interactivity.EventTrigger  '   	EventName$' Click��.  (System.Windows.Interactivity.TriggerBase(   Actions.( 6  0System.Windows.Interactivity.InvokeCommandAction  )   Command) �� * �� RelativeSource* �� + �� AncestorType"+ >�$% DataContext.TakeToBasketCommand�.��'  !MaterialDesignThemes.Wpf.PackIcon  ,   Kind$
, Plus=�$��20��$��20��
�������	    �� $��Bekor qilish��$
��120 ��
�������$��Segoe UI)�$��15(�$$ Center=�% �� .R���   	btnCancel#��[ $��60��&   $' Click��.(   ) �� * �� "+ >�$# DataContext.CancelShopCommand�.���� $!��../Images/cancelRecieve.png��$��20��$��20��