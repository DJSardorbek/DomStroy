   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity (    "DomStroyB2C_MVVM.Views.PaymentView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:DomStroyB2C_MVVM.Views     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aDmateilDesign1http://materialdesigninxaml.net/winfx/xaml/themes  3System&clr-namespace:System;assembly=mscorlib  XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity    � Title$  PaymentView��$	��575��$	��966�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=����#C0C0C0$��1q���Z�  J� InputBindings �� 
 �� Key$ F2�� �� Command �� *HundredCashCommand+�� $ F3�� �� *HundredCreditCartCommand+�� $ F4�� �� *HundredTransferCommand+ � 	Resources 	 �� 
TargetType   txtInformation
 �� Property �� Value  	txtClient-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� Padding ��Name J� IsHitTestVisible
 � Tag �� Padding �� Triggers �� Binding �� RelativeSource �� Value  	btnClient P� Property P� Value  	ComboBox1 d� 	IsChecked �� Path �� Mode � ColumnDefinitions �� CornerRadius F�Name �� Triggers  �� 
TargetName! �� SelectionBoxItem" �� SelectionBoxItemTemplate# ��Name$ �� 
IsReadOnly% �� 
IsReadOnly& �� IsDropDownOpen' � AllowsTransparency( J� SnapsToDevicePixels) � ActualWidth* �� MaxDropDownHeight+ K� IsItemsHost��%�  &	        &	 Y     &	 �    &	 �    �� "	 ��.��� 
 � ��$ Segoe UI)��� 
 � ��$
 20px(��� 
 � ��
 ������� "	 ��.��� 
 �@J�SnapsToDevicePixels . �� 
 �@�OverridesDefaultStyle . �� 
 �@ TabNavigation$
 None=��� 
 �@�FocusVisualStyle Z� �� 
 �@J�	AllowDrop . �� 
 �@��
CaretBrush �#FFFFFF�� 
 � ��$	 235���� 
 � ��$ 60���� 
 � ��$ Bottom=��� 
 � �� �#6783B8�� 
 � ��
 ������� 
 � �� �#6783B8�� 
 � ��$ Segoe UI)��� 
 � ��$
 20px(��� 
 � �� �� " ��.R�� .+��� $ Border��$ 	20 10 5 5q�$��1q�#��z��#��z��._��� $ PART_ContentHost��$��0q���  .  #��z $ 	60 15 5 5q����� "	 ��.��� 
 � y�$ 	Collapsed=��� 
 � �� �#EFEEEF�� 
 � ��$ Segoe UI)��� 
 � ��$
 15px(� ��  �� *Text+ �� *TemplatedParent+  .a��� 
 � y�$ Visible=��� "	 ��.��� 
 � �� �#6783B8�� 
 � �� �� " ��.R��� $��0q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 
 �@J�Opacity$	 0.7Q�P�  �@�Tag$ Valyuta��. ��� 
 � �� �#FFFFEF�� "	 ��.��� 
 � �� �#283654�� 
 � ��$ Segoe UI)��� 
 � ��$
 20px(��� 
 � �� �� " ��.R�� .+�d� $��2��|�.   �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+���� .R��  �� $��5* ��� $��* �.+��� $ Border��$��2��$ 5 0 0 5�����#FFFFFF���#4D638C$��1q��� $��0��$ 5,0,0,5��$��1q����#FFFFFF���#4D638C$��0,0,0,0q�F� $ Arrow��$��1�����#283654$��Center=�$��Center=�"����        � 	=  	= � z     	 P�  �@J�IsMouseOver . . ��� $  Border��
 � �� �#FFFFEFP�  �@d�	IsChecked$
 trueY�. ��� $  Border��
 � �� �#FFFFEF�� $��ContentSite�� .  #��z! #��z" #��z��$��3q�$��Center=�$��Center=��� $# PART_EditableTextBox��$y�Hidden=�#% z$ � $��Popup��$��Bottom=�#��z& ' . |�.  $��Slide=�.��� $��DropDown��( . #��z) #��z* .+��� $ DropDownBorder�����#FFFFEF�� ( . .���� + .  .���  �� $	��356 ��� $��* �.+�� $��0�����#4D638C, � RowDefinitions, �� $	��210 ��� $	��330 ��� $��* �.+��� $��0��.+��� #��[  $��Mijoz��$��
47 47 0 12q��  �� $	��270 ��� $��* �.+�� $��0��.+��� -   #��[ $��34 0 0 0q�$
��14px(�- � Cursor$- Arrow��$ Mijozni tanlang...��.������ $ Search�$ TwoWay=�. �� UpdateSourceTrigger$. PropertyChanged=�.��.  (System.Windows.Interactivity.Interaction/   Triggers/ /  )System.Windows.Interactivity.EventTrigger  0   	EventName$0 TextChanged��.  (System.Windows.Interactivity.TriggerBase1   Actions.1 6  0System.Windows.Interactivity.InvokeCommandAction  2   Command2 �� *SearchCommand+.��� $��1�����#6783B8$��60��$��0 0 32 0q�.+��� #��[ $
- Hand������ *ClientVisibilityCommand+.���� $��../Images/arrow.png��$��24��$��14��� $��1��$��	0 -66 0 0q�y��� *ClientDataGrid+, �� �� $��50 �.+��� -   $ scrollViewer1��$��Disabled=����� "	 �� ��  �� *
HasItems+3 �� ElementName$3 dataGrid��	 False.a��� 
 � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -   4  Name$4 dataGridClient��$y�Visible=�$5   HorizontalScrollBarVisibility$
5 Auto=�$
��Auto��6   HorizontalGridLinesBrush6 �#E3E2E27   AutoGenerateColumns7 .  8   GridLinesVisibility$8 
Horizontal=�9   CanUserAddRows9 .  :   CanUserDeleteRows: .  ;   
IsReadOnly; .  <   CanUserReorderColumns< .  =   CanUserResizeColumns= .  >   CanUserResizeRows> .  ?   CanUserSortColumns? .  ���#FFFFFF$��0q����#C0C0C0@   SelectionMode$@ Single=�A   SelectionUnit$A FullRow=�$��	35 0 32 0q����� *
ClientList+B �� SelectedItemB �� $ Client�$ TwoWay=� �� $ Enter�� �� *ChooseClientCommand+/   $0 MouseDoubleClick��.1   2 �� *ChooseClientCommand+   MaterialDesignDataGridC �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=	  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%a  '        7  '  D     7  '  ,    '	  a    7  '�� �    �� "	  8C   .��� 
 �@ GridLinesVisibility$ 
Horizontal=��� "	  8C   .��� 
 �@�FocusVisualStyle Z� �� 
 � �� �#7A7979�� 
 � ��$ 0q��� 
 � ��$ 38���� 
 �@��TextAlignment$
 Left=� P�  �@ 
IsSelected . . ��� 
 � �� �#B6E0FF�� "	  .��� 
 �@��TextAlignment$ Center=��� "	 	 8C   .��� 
 � �� �#283654�� 
 � ��
 ������� 
 � y�$ 	Collapsed=��� 
 � ��$
 Left=��� 
 � ��$ Center=� �� "	 ��.��� 
 � �� �#263859D   ColumnsD 0
  *System.Windows.Controls.DataGridTextColumn
  ,  &System.Windows.Controls.DataGridColumnE   Header$E Mijoz��F   
IsReadOnlyF . G   Width5  /System.Windows.Controls.DataGridLengthConverter$G * 1  +System.Windows.Controls.DataGridBoundColumnH   BindingH �� $ FullName��� $��1��#��[ $��	35 4 32 0q����� *AddClientCommand+.���� $��+ Yangi mijoz qo'shish��$��Segoe UI)�$
��14px(�
��������� $��1��y��� *ClientInfoVisibility+.+��� $��1��#��[  $��
47 0 0 20 q��� $�Qarzdorlik:   Uz:�� �� ��� $ Loan_sum�$ TwoWay=��� $��1��#��[  $��
47 0 0 20 q��� $�                       $:�� �� ��� $ Loan_dollar�$ TwoWay=��� $��2��$��
0 -200 0 0q�y��� *CalendarVisibility+.+��� $��1��#��[  $��	47 0 0 0 q��� $�Nasiya miqdori: �� �� ��� *
Total_loan+�� ���#4D638C$��1q�$��40��$��	47 0 25 0q�$ 3�����#4D638C._�(  "System.Windows.Controls.DatePicker  $��1��$	��138��$��35��$
��Left=�$��0 10 0 0q�
�������I   SelectedDateI �� *
ReturnDate+$ TwoWay=�
J �� NowK �� TargetNullValue#K ZJ � $��1��
�������, �� $	��100 ��� �� .+�� $��0��.+��� $��To'lov oynasi��$��Segoe UI)�$
��40px(����#4D638C$��SemiBold"�$��Center=�$��Center=��� -   L ��Name$L btnClose��$	��Top=�$��
0 14 14 14q�$
- Hand��.���� $��../Images/Close.png��$��30��$��30������ "	 ��.��� 
 � ��$ 35���� 
 � ��$ 35���� 
 � ��$ 	0 15 20 0q��� 
 � ��$ Right=��� 
 � ��
 ������� 
 � ��
 ������� 
 � �� �� " ��.R��� #��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 
 � ��
 ������ $��1��, �� �� .+�� $��0��, �� $��15 ��� $��65 �.+�� $��0�� �� $	��270 ��� $��* �.+��� $��0��$��Valyuta�����#283654$
��12px(�$��72 0 0 0q�$��SemiBold"��� $��1��$��Harid summasi:�����#283654$
��12px(�$��0 0 0 0q�$��SemiBold"�$
��Left=��� $��1��M �� Orientation$M 
Horizontal=�.+��� $	��206��$��52��$��53 0 0 0q�$ 5 0 0 5��$��1q����#283654._��  �� $	��160 ��� $��46 �.+��� $M 
Horizontal=�.+��� -   N ��Name$N txtCurrencyType��$��Segoe UI)�$
��20px(�$��Center=����#283654$
��Left=�$��15 0 0 0q����� $ CurrencyType�$ TwoWay=��� -   $N txtCurrency��$��90��$��Segoe UI)�$
��14px(�$��Bottom=����#283654$��SemiBold"�$��	10 0 0 10q�y��� $ CurrencyVisibility�$ TwoWay=��� $�kursi: �� �� ��� $ Currency�$ TwoWay=��� -   $L btnChangeCurrency��$��1��$��46��$ Valyuta��#��[ $
- Hand������ *ChangeCurrencyCommand+.���� $"��../Images/changeCurrency.png��$��19��$��19���� $ 0 5 5 0��$��0 1 1 1q����#283654$	��333��$��52��._��� $
��20px(�$��Segoe UI)����#283654$��Center=�$��20 0 0 0q����� $ 	Total_sum�$ TwoWay=�� $��1��, �� $��15 ��� $��65 �.+�� $��0�� �� $	��270 ��� $��* �.+��� $��0��$��To'lov turi�����#283654$
��12px(�$��72 0 0 0q�$��SemiBold"��� $��1��$��To'lov summasi:�����#283654$
��12px(�$��0 0 0 0q�$��SemiBold"�$
��Left=��� $��1��$M 
Horizontal=�.+��� -   O ��Name$O comboCurrency��#��[ $	��207��$��51��$��49 0 0 0q�P �� TextP �� $ PaymentType�$ OneWayToSource=�Q �� SelectedIndexQ �� $ PaymentType�$ OneWayToSource=�.@��� .���� $M 
Horizontal=�.+��� $��Asosiy kassa���� $��../Images/PavCash.png��$��20��$��25��$��8 0 0 0q��� .���� $M 
Horizontal=�.+��� $��Plastik karta���� $��../Images/Pavcard.png��$��20��$��25��$��8 0 0 0q��� .���� $M 
Horizontal=�.+��� $	��X/R���� $��../Images/PavTransfer.png��$��20��$��25��$��8 0 0 0q��� -	   $# txtPayedSumma��$	��281��$��51��$��0 1 1 1q����#283654$
��20px(����#283654$��
20 10 10 0q�R �� 
CaretBrushR �#283654.������ $ 
PayedSumma�$. PropertyChanged=�.�� �� $ Return�� �� *SubmitPaymentCommand+.���� $
- Hand������ *SubmitPaymentCommand+.���� $��../Images/+.png��$��20��$��20������ "	 ��.��� 
 � ��$ 48���� 
 � ��$ 51���� 
 � ��
 ������� 
 � �� �� " ��.R��� $ 0 5 5 0��$��0 1 1 1q����#283654#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 
 � �� �#FFFFEF� $��2��, �� $��60 ��� $��* �.+��� $��0��$M 
Horizontal=�$��Center=�.+���   
btnBorder5#��[ $	��172��$��40��$��	20 0 10 0q�.���� $��(F2) Naqd pul 100%��$��Segoe UI)�$
��16px(�
��������� #��[ $	��172��$��40��$��0 0 10 0q�.���� $��(F3) Plastik karta 100%��$��Segoe UI)�$
��16px(�
��������� #��[ $	��172��$��40��.���� $��(F4)  X/R 100%��$��Segoe UI)�$
��16px(�
�������� $��1��$��	45 0 25 0q� �� $	��205 ��� $��* �.+��� -
   $��0������ *FinalizePaymentCommand+.���� $��To'lov��$��	Segoue UI)�$
��50px(�
����������� "	 ��.��� 
 � �� �#4D638C�� 
 � ��$	 104���� 
 � �� �� " ��.R��� $ 5 0 0 5��$��1q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 
 �@J�Opacity$	 0.8Q��� 
 � ��$ DemiBold"��� $��1��$ 0 5 5 0��$��0 1 1 1q����#283654$	��104��._��� $��Center=�.+��� -   $ 	stackNaqd��$��0 0 0 1q����#283654y��� $ CashVisibility�._��� $M 
Horizontal=�.+��� $��../Images/PavCash.png��$��20��$��25��$��8 0 0 0q��� $	��270��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *Cash+��   	btnSearch#��[ $��0q�$��30������ *ClearCashCommand+.���� $��../Images/x.png��$��15���� -   $ stackPlastik��$��0 0 0 1q����#283654y��� $ CreditCardVisibility�._��� $M 
Horizontal=�.+��� $��../Images/PavCard.png��$��20��$��25��$��8 0 0 0q��� $	��270��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *
CreditCard+�� #��[ $��0q�$��30������ *ClearCreditCardCommand+.���� $��../Images/x.png��$��15���� -   $ stackXR��$��0 0 0 1q����#283654y��� $ TransferVisibility�._��� $M 
Horizontal=�.+��� $��../Images/PavTransfer.png��$��20��$��25��$��8 0 0 0q��� $	��270��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *
Transfer+�� #��[ $��0q�$��30������ *ClearTransferCommand+.���� $��../Images/x.png��$��15��