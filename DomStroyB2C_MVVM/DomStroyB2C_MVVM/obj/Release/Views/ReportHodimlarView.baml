   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  /    )DomStroyB2C_MVVM.Views.ReportHodimlarView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources     CalendarOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  CalendarClose��%�   &	        &	 r     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 332Q�  $ 0:0:0.4��$	 605Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 605Q�  $ 0:0:0.4��$	 332Q� � Triggers :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ ButtonCloseCalendar��.[��� #��[  .��� ���#EDEDED � RowDefinitions �� $��80 ��� $��* �.+�� $��0��$��0 10 0 0q�.+��� -   	 ��Name$	 GridMenu��
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
 25��$��1q����#283654���#283654._��� $��Center=�$��Center=�� $��2�� �� $��60 ��� $��* �.+��� $(��"Hodimlar aktivligi bo'yicha analiz��$��Segoe UI)�$
��33px(����#283654$	��Top=�$��Center=�$��0q��� -    ��Name$ scrollViewer��$��1��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -      Name$  dataGridREmployee��$y�Visible=�$!   HorizontalScrollBarVisibility$
! Auto=�$
��Auto��"   HorizontalGridLinesBrush" �#E3E2E2#   AutoGenerateColumns# .  $   GridLinesVisibility$$ 
Horizontal=�%   CanUserAddRows% .  &   CanUserDeleteRows& .  '   
IsReadOnly' .  (   CanUserReorderColumns( .  )   CanUserResizeColumns) .  *   CanUserResizeRows* .  ���#FFFFFF$��
20 0 20 20q�$��1q�+   SelectionMode$+ Single=�,   SelectionUnit$, FullRow=�- �� AlternationCount$- 2��    MaterialDesignDataGrid. �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%Z  '        7  '  D     7  '  H    '  �    7  '�� �    �� "  8.   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8.   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=���  � ��$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8.   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $
 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859/   Columns/ 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn0   Header$	0 №��1   
IsReadOnly1 . 2   Width5	  /System.Windows.Controls.DataGridLengthConverter$2 80	 1
  +System.Windows.Controls.DataGridBoundColumn3 
  Binding3 �� *id+  $
0 Ismi��1 . $
2 150*	 3 �� *
employee+  $0 Filial��1 . $
2 150*	 3 �� *filial+  $0 	Naqd so'm��1 . $
2 100*	 3 �� *
naqd_som+  $0 Naqd dollar��1 . $
2 150*	 3 �� *naqd_dollar+  $0 Plastik��1 . $
2 100*	 3 �� *	plastik+  $0 Pul o'tkazish��1 . $
2 100*	 3 �� *
transfer+  $0 Nasiya so'm��1 . $
2 200*	 3 �� *
nasiya_som+  $0 Nasiya dollar��1 . $
2 200*	 3 �� *nasiya_dollar+