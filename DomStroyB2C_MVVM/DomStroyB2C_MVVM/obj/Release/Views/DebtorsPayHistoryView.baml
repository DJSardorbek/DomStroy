   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  2    ,DomStroyB2C_MVVM.Views.DebtorsPayHistoryView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  .��� ���#E5E5E5  � RowDefinitions  �� $��50 ��� $��20 ��� $	��120 ��� $��* ��� $
��Auto �.+�� $��0�����#4D638C.+��� ���� *BackToDebtorsCommand+����  �� 
TargetType" ��.���  �� Property � �� �� Value$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30���� $��To'lov tarixi��
�������$��Segoe UI)�$
��20px(�$��Center=�$
��Left=�$��	100 0 0 0q��� -    ��Name$ ButtonOpenCalendar��$y�Visible=�.��� $	��308��	 � ColumnDefinitions	 �� $��* ��� $��* �.+�� $��0��$��Right=�$��0 0 10 0q�	 �� $��* ��� $
��Auto �.+�(  "System.Windows.Controls.DatePicker  $��0�����#778DB8�� $��1��$	��dan��$��5 0 0 0q�
 �� TextAlignment$
 Center=�$��Center=�$��Center=�
�������$��Segoe UI)�$
��13px(�� $��1��$��Right=�$��0 0 10 0q�	 �� $��* ��� $
��Auto �.+�  $��0�����#778DB8�� $��1��$��gacha��$��5 0 0 0q�$
 Center=�$��Center=�$��Center=�
�������$��Segoe UI)�$
��13px(����� " ��.���  � ��$	 328����  � ��$ 40����  � ��$ 
0 -2 30 0 q���  � ��$ Right=���  � �� �� " ��.R���  �� CornerRadius$ 25��$��1q����#283654���#283654._��� $��Center=�$��Center=�� $��1��$
��Left=�$��47 0 0 0q�� $��2��.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGridClient��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2��$��
25 0 25 20q����� *ClientDetail1+ �� Mode$ OneWay=� �� SelectedItem �� *ClientDetail1+$ OneWay=� � 	Resources    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%\  '        7   '  D     7  '  J    '  �    7  '�� �    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 50����  � ��$ 0q���  � �� �#263859��  �@��TextAlignment$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 42����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mijoz��    
IsReadOnly  . !   Width5  /System.Windows.Controls.DataGridLengthConverter$
! 200* 1	  +System.Windows.Controls.DataGridBoundColumn" 	  Binding" �� *
first_name+  $ Telefon raqami��  . $
! 200* " �� *	phone_1+  $ Karta raqami��  . $
! 200* " �� *discount_card+  $ Manzili��  . $
! 200* " �� *	address+� $��3��.+��� -   # ��Name$# scrollViewer��$��Disabled=����� " �� �� $ �� Binding$ �� *
HasItems+% �� ElementName$% dataGrid��& �� Value	& False.a���  � ��$
 Auto=�.��  -   $ dataGridPayHistory��$y�Visible=�$
 Auto=�$
��Auto�� �#E3E2E2 .  $ 
Horizontal=� .   .   .   .   .   .  ���#FFFFFF$��1q�$ Single=�$ FullRow=�$ 2��$��
25 0 25 20q����� *PaymentList.results+$ TwoWay=� ��%*  '        7   '  D     7  '      '  �    7  '�� �    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  �@��TextAlignment$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859   $
 Sana��  . $	! 200 " �� *	paid_at+  $ 	Naqd so'm��  . $
! 150* " �� *
cash_sum+  $ Naqd dollar��  . $
! 150* " �� *cash_dollar+  $ Plastik��  . $
! 150* " �� *card+  $ Pul o'tkazish��  . $
! 150* " �� *
transfer+  $ Balldan��  . $
! 150* " �� *	from_ball+  $ Diskount so'm��  . $
! 150* " �� *discount_sum+  $ Diskount dollar��  . $
! 150* " �� *discount_dollar+� $��3��$	��200��$	��200��$��0 0 0 0q�y��� *LoadingVisibility+��!� ' !� Visual' �� "
  WpfAnimatedGif.ImageBehavior( 
  AnimatedSource$ ( /Views/Loading/loading.gif��) 
  	AutoStart) . * 
  RepeatBehavior$* 1��� -   + �Name$+ GridPage��$��4��$	��200��$��0 0 0 5q�y��� *PageVisibility+$ TwoWay=�	 �� �� .+��� -   $ 
btnPrevius��$��0��{��� *LeftEnabled+$ TwoWay=�, J� Opacity, �� *LeftOpacity+$ TwoWay=����� *PreviousCommand+.���� .+�'  !MaterialDesignThemes.Wpf.PackIcon  -   Kind$- 	ArrowLeft=�$��25��$��25������ " ��.���  � ��$ 50����  � ��$ 50����  � �� �#263859��  � �� �#263859��  � ��
 �������  � �� �� " ��.R��� $ 50��#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � ��$ 2q���  � �� �#455A64��  � �� �#455A64�� -   $ btnNext��$��1��{��� *RightEnabled+$ TwoWay=�, �� *RightOpacity+$ TwoWay=����� *NextCommand+.���� .+�  $- 
ArrowRight=�$��25��$��25������ " ��.���  � ��$ 50����  � ��$ 50����  � �� �#263859��  � �� �#263859��  � ��
 �������  � �� �� " ��.R��� $ 50��#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � ��$ 2q���  � �� �#455A64��  � �� �#455A64