   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  ,    &DomStroyB2C_MVVM.Views.ReportSavdoView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources     CalendarOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  CalendarClose��%�   &	        &	 r     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 332Q�  $ 0:0:0.4��$	 605Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 605Q�  $ 0:0:0.4��$	 332Q� � Triggers :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ ButtonCloseCalendar��.[��� #��[  .��� ���#EDEDED � RowDefinitions �� $��80 ��� $	��110 ��� $��* �.+�� $��0��$��0 10 0 0q�.+��� -   	 ��Name$	 GridMenu��
 �� CornerRadius$
 25��$	��332��$��44��$��1q����#FFFFFF���#FFFFFF._��  � ColumnDefinitions �� $
��Auto ��� $
��Auto �.+��� $	��252��$��44�� �� Orientation$ 
Horizontal=�$
��Left=�$��	22 -2 0 0q�.+��� -    ��Name$
 tab1��$��0q����#FFFFFF.@��� ����  �� 
TargetType" ��.���  �� Property � �� �� Value �#302F2F��  � �� �#FFFFFF��  � �� �#FFFFFF��  � ��$ 1q���  � ��$ Segoe UI)���  � ��$
 15px(���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� $
 0��$��1q����#EDEDED#��z��._��� $��Bugun��$��Center=�$��Center=� �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  � �� ��  �� 
StartPoint$ 0.5,0&� �� EndPoint$ 0.5,1&�.���  � Color$ #FFFFFF�� � Offset$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$	 1.0Q���  � �� �#302F2F�� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � ��$ Segoe UI)���  � ��$ 0q���  � ��$
 15px(���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $
 0��$��1q����#EDEDED#��z��._��� $��Hafta��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� �� $ 0.5,0&�$ 0.5,1&�.��� $ #FFFFFF��$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$ 1Q���  � �� �#302F2F�� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � ��$ Segoe UI)���  � ��$
 15px(���  � ��$ 0q���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $
 0��$��1q����#EDEDED#��z��._��� $��Oy��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� �� $ 0.5,0&�$ 0.5,1&�.��� $ #FFFFFF��$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$ 1Q���  � �� �#302F2F�� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � ��$ Segoe UI)���  � ��$ 0q���  � ��$
 15px(���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $
 0��$��1q����#EDEDED#��z��._��� $	��Yil��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� �� $ 0.5,0&�$ 0.5,1&�.��� $ #FFFFFF��$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$ 1Q���  � �� �#302F2F� -    �Name$ GridCalendar��$��1��.+��� -    ��Name$ ButtonCloseCalendar��$y�Visible=�.���� $��../Images/date.png��$��24��$��24������ " ��.���  � ��$ 56����  � ��$ 44����  � ��$ 
-0 -2 0 0 q���  � �� �� " ��.R��� $
 25��$��1q����#283654���#283654._��� $��Center=�$��Center=��� -   $ ButtonOpenCalendar��$y�	Collapsed=�.��� $	��308�� �� $��* ��� $��* �.+�� $��0��$��Right=�$��0 0 10 0q� �� $��* ��� $
��Auto �.+�(  "System.Windows.Controls.DatePicker  $��0�����#778DB8�� $��1��$	��dan��$��5 0 0 0q� �� TextAlignment$ Center=�$��Center=�$��Center=�
�������$��Segoe UI)�$
��13px(�� $��1��$��Right=�$��0 0 10 0q� �� $��* ��� $
��Auto �.+�  $��0�����#778DB8�� $��1��$��gacha��$��5 0 0 0q�$ Center=�$��Center=�$��Center=�
�������$��Segoe UI)�$
��13px(����� " ��.���  � ��$	 328����  � ��$ 44����  � ��$ 	0 -2 0 0 q���  � �� �� " ��.R��� $
 25��$��1q����#283654���#283654._��� $��Center=�$��Center=�� $��1��.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGridSumma��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .      GridLinesVisibility$	  All=�!   CanUserAddRows! .  "   CanUserDeleteRows" .  #   
IsReadOnly# .  $   CanUserReorderColumns$ .  %   CanUserResizeColumns% .  &   CanUserResizeRows& .  ���#FFFFFF$��1q�'   SelectionMode$' Single=�(   SelectionUnit$( FullRow=�) �� AlternationCount$) 2��$��
20 0 20 20q�    MaterialDesignDataGrid* �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%�  '        7  '  D     7  '  �    '  ,    7  '�� ?    �� "  8*   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8*   .���  �@�FocusVisualStyle Z� ��  � �� �#FFFFFF��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  � ��$ SemiBold"���  � ��$ 16(���  � �� �#263859��  �@��TextAlignment$ Center=� P�  �@ 
IsSelected . . ���  � ��
 ������� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8*   .���  � �� �#283654��  � ��
 �������  � ��$ 42����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $
 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859+   Columns+ 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn,   Header$, 	Naqd so'm��-   
IsReadOnly- . .   Width5	  /System.Windows.Controls.DataGridLengthConverter$
. 150*	 1
  +System.Windows.Controls.DataGridBoundColumn/ 
  Binding/ �� *
naqd_som+  $, Naqd dollar��- . $
. 150*	 / �� *naqd_dollar+  $, Plastik��- . $
. 150*	 / �� *	plastik+  $, Pul o'tkazma��- . $
. 150*	 / �� *
transfer+4  .System.Windows.Controls.DataGridTemplateColumn  , �� $��Nasiya��$
 Left=�$	��200��0   CellTemplate0 �� .R�� $	��200�� �� $��* ��� $��* � �� $��70 ��� $��* �.+�� $��0��$��0��.+��� $��So'm:��$��SemiBold"����#283654$��Segoe UI)�$
��15px(�$��Center=�$
��Left=�� $��0��$��1��$
��Left=�.+��� $
��14px(����� *som+� $��1��$��0��.+��� $��Dollar:��$��SemiBold"����#283654$��Segoe UI)�$
��15px(�$��Center=�$
��Left=�� $��1��$��1��$
��Left=�.+��� $
��14px(����� *dollar+  , �� $��Vazvrat��$
 Left=�$	��200��0 �� .R�� $	��200�� �� $��* ��� $��* � �� $��70 ��� $��* �.+�� $��0��$��0��$
��Left=�.+��� $��So'm:��$��SemiBold"����#283654$��Segoe UI)�$
��15px(�$��Center=�$
��Left=�� $��0��$��1��.+��� $
��14px(����� *som+� $��1��$��0��$
��Left=�.+��� $��Dollar:��$��SemiBold"����#283654$��Segoe UI)�$
��15px(�$��Center=�$
��Left=�� $��1��$��1��.+��� $
��14px(����� *dollar+� $��2�� �� $��60 ��� $��* �.+��� $3��-Eng ko'p sotilgan mahsulotlar bo'yicha analiz��$��Segoe UI)�$
��33px(����#283654$	��Top=�$��Center=�$��0q��� -   1 ��Name$1 scrollViewer��$��1��$��Disabled=����� " �� �� 2 �� Binding2 �� *
HasItems+3 �� ElementName$3 dataGrid��4 �� Value	4 False.a���  � ��$
 Auto=�.��  -   $ dataGridSale��$y�Visible=�$
 Auto=�$
��Auto�� �#E3E2E2 .  $  
Horizontal=�! .  " .  # .  $ .  % .  & .  ���#FFFFFF$��
20 0 20 20q�$��1q�$' Single=�$( FullRow=�$) 2��  ��%Z  '        7  '  D     7  '  H    '  �    7  '�� �    �� "  8*   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8*   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=���  � ��$ Center=� P�  �@ 
IsSelected . . ���  � �� �#4D638C�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8*   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $
 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859+   $	, №��- . $. 80	 / �� *id+  $
, Nomi��- . $
. 150*	 / �� *name+  $, O'lchov birligi��- . $
. 150*	 / �� *measurement+  $, Miqdori��- . $
. 100*	 / �� *
quantity+  $, Umumiy summa��- . $
. 150*	 / �� *name+  $, Valyuta��- . $
. 100*	 / �� *	valyuta+  $, Qoldiq��- . $
. 100*	 / �� *price+  $, Keltirilgan sana��- . $
. 200*	 / �� *price+  , �� 