   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  0    *DomStroyB2C_MVVM.Views.ProductMovementView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views       � 	Resources     CalendarOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  CalendarClose��%�   &	        &	 r     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 332Q�  $ 0:0:0.4��$	 605Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 605Q�  $ 0:0:0.4��$	 332Q� � Triggers :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ ButtonCloseCalendar��.[��� #��[  .��� ���#EDEDED � RowDefinitions �� $��50 ��� $
��Auto ��� $��* �.+�� $��0�����#4D638C.+���   	txtSearch#��[ 
	 � Tag$	 	Izlash...��$	��520��$��34��$��Center=�$��Right=�$��0 0 20 0q�$��	30 5 50 5q��� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q��� .��� 
 � ColumnDefinitions
 �� $	��200 ��� $��* �.+��� $��0��$��Yangi yaratish������  �� 
TargetType" ��.���  �� Property � �� �� Value$ Segoe UI)���  � ��
 �������  � ��$ 26 0 0 0q���  � ��$ Center=���  � ��$
 20px(��� $��1�� �� CornerRadius$ 20��$��38��$��36��
�������._��� $��../Images/plus.png��$��15��$��15������ " ��.���  � ��$	 240����  � ��$ 38����  � ��$ Right=���  � ��$ 	0 0 560 0q���  � �� �#ABB8D4��  � �� ��  �� 
TargetType" ��.R��� $��1q�$ 20��#��z��#��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �@J�Opacity$	 0.8Q�� $��1��$��	0 10 0 10q�
 �� $	��300 ��� $��* ��� $	��300 �.+��� .+��� $��	Filialdan�����#000000$��Segoe UI)�$
��12px(�$��Center=�$
��Left=�$��SemiBold"�$��	20 10 0 0q��� $��0��$	��250��$��35��  ComboBoxTest2#��[ $
��Left=�$��	20 10 0 0q��� -    ��Name$ GridMenu��$��1��$ 25��$	��332��$��44��$��1q����#FFFFFF���#FFFFFF$��0 20 0 0q�._�� 
 �� $
��Auto ��� $
��Auto �.+��� $	��252��$��44�� �� Orientation$ 
Horizontal=�$
��Left=�$��	22 -2 0 0q�.+��� -    ��Name$
 tab1��$��0q����#FFFFFF.@��� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � �� �#FFFFFF��  � ��$ 1q���  � ��$ Segoe UI)���  � ��$
 15px(���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $ 0��$��1q����#EDEDED#��z��._��� $��Bugun��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� ��  �� 
StartPoint$ 0.5,0&� �� EndPoint$ 0.5,1&�.���  � Color$ #FFFFFF�� � Offset$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$	 1.0Q���  � �� �#302F2F�� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � ��$ Segoe UI)���  � ��$ 0q���  � ��$
 15px(���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $ 0��$��1q����#EDEDED#��z��._��� $��Hafta��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� �� $ 0.5,0&�$ 0.5,1&�.��� $ #FFFFFF��$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$ 1Q���  � �� �#302F2F�� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � ��$ Segoe UI)���  � ��$
 15px(���  � ��$ 0q���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $ 0��$��1q����#EDEDED#��z��._��� $��Oy��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� �� $ 0.5,0&�$ 0.5,1&�.��� $ #FFFFFF��$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$ 1Q���  � �� �#302F2F�� ���� " ��.���  � �� �#302F2F��  � �� �#FFFFFF��  � ��$ Segoe UI)���  � ��$ 0q���  � ��$
 15px(���  � ��$ 62����  � ��$ 43����  � ��$ 0 0 0 0q���  � �� �� " ��.R��� $ 0��$��1q����#EDEDED#��z��._��� $	��Yil��$��Center=�$��Center=� P�  �@��
IsSelected . . ���  � �� �� $ 0.5,0&�$ 0.5,1&�.��� $ #FFFFFF��$ 0Q�� $ #FFFFFF��$
 0.25Q�� $ #FFFFFF��$	 0.5Q�� $ #79A0E9��$ 1Q���  � �� �#302F2F� -    �Name$ GridCalendar��$��1��.+��� -    ��Name$ ButtonCloseCalendar��$y�Visible=�.���� $��../Images/date.png��$��24��$��24������ " ��.���  � ��$ 56����  � ��$ 44����  � ��$ 
-0 -2 0 0 q���  � �� �� " ��.R��� $ 25��$��1q����#283654���#283654._��� $��Center=�$��Center=��� -   $ ButtonOpenCalendar��$y�	Collapsed=�.��� $	��308��
 �� $��* ��� $��* �.+�� $��0��$��Right=�$��0 0 10 0q�
 �� $��* ��� $
��Auto �.+�(  "System.Windows.Controls.DatePicker  $��0�����#778DB8�� $��1��$	��dan��$��5 0 0 0q� �� TextAlignment$ Center=�$��Center=�$��Center=�
�������$��Segoe UI)�$
��13px(�� $��1��$��Right=�$��0 0 10 0q�
 �� $��* ��� $
��Auto �.+�  $��0�����#778DB8�� $��1��$��gacha��$��5 0 0 0q�$ Center=�$��Center=�$��Center=�
�������$��Segoe UI)�$
��13px(����� " ��.���  � ��$	 328����  � ��$ 44����  � ��$ 	0 -2 0 0 q���  � �� �� " ��.R��� $ 25��$��1q����#283654���#283654._��� $��Center=�$��Center=��� $��2��  btnSell#��[ $	��205��$��42��$��Bottom=�$��Right=�$��0 0 20 0q�.���� $��
Tasdiqlash��$
��15px(�� $��2��.+��� -    ��Name$ scrollViewer��$��Disabled=����� " �� ��  �� Binding �� *
HasItems+ �� ElementName$ dataGrid��  �� Value	  False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -   !  Name$! dataGridMovement��$y�Visible=�$"   HorizontalScrollBarVisibility$
" Auto=�$
��Auto��#   HorizontalGridLinesBrush# �#E3E2E2$   AutoGenerateColumns$ .  %   GridLinesVisibility$% 
Horizontal=�&   CanUserAddRows& .  '   CanUserDeleteRows' .  (   
IsReadOnly( .  )   CanUserReorderColumns) .  *   CanUserResizeColumns* .  +   CanUserResizeRows+ .  ���#FFFFFF$��10q�$��1q�,   SelectionMode$, Single=�-   SelectionUnit$- FullRow=�. �� AlternationCount$. 2��    MaterialDesignDataGrid/ �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%Z  '        7  '  D     7  '  H    '  �    7  '�� �    �� "  8/   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8/   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$ Center=���  � ��$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8/   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#2638590   Columns0 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn1   Header$	1 №��2   
IsReadOnly2 . 3   Width5	  /System.Windows.Controls.DataGridLengthConverter$3 80	 1
  +System.Windows.Controls.DataGridBoundColumn4 
  Binding4 �� *id+  $1 Faktura nomi��2 . $
3 150*	 4 �� *faktura_name+  $1 Hodim��2 . $
3 150*	 4 �� *
employee+  $1 Dollar��2 . $
3 130*	 4 �� *dollar+  $1 So'mda��2 . $
3 130*	 4 �� *som+  $
1 Sana��2 . $
3 130*	 4 �� *date+  $1 	Filialdan��2 . $
3 150*	 4 �� *from_branch+  $1 Filialga��2 . $
3 150*	 4 �� *	to_branch+