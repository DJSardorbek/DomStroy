   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  ,    &DomStroyB2C_MVVM.Views.DebtPaymentView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:DomStroyB2C_MVVM.Views     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com    � Title$  PaymentView��$	��545��$	��610�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=���Z�  � 	Resources  �� 
TargetType   txtInformation �� Property �� Value  	txtClient-  'System.Windows.Input.KeyboardNavigation	 �� 
TargetType
 ��Name �� Padding ��Name J� IsHitTestVisible
 � Tag �� Padding �� Triggers �� Binding �� RelativeSource �� Value  	btnClient P� Property P� Value  	ComboBox1 d� 	IsChecked �� Path �� Mode � ColumnDefinitions �� CornerRadius F�Name �� Triggers �� 
TargetName �� SelectionBoxItem �� SelectionBoxItemTemplate  ��Name! �� 
IsReadOnly" �� 
IsReadOnly# �� IsDropDownOpen$ � AllowsTransparency% J� SnapsToDevicePixels& � ActualWidth' �� MaxDropDownHeight( K� IsItemsHost��%�  &	        &	 Y     &	 �    &	 �    �� " ��.���  � ��$ Segoe UI)���  � ��$
 20px(���  � ��
 ������� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��
CaretBrush �#FFFFFF��  � ��$	 235����  � ��$ 60����  � ��$ Bottom=���  � �� �#6783B8��  � ��
 �������  � �� �#6783B8��  � ��$ Segoe UI)���  � ��$
 20px(���  � �� �� "	 ��.R�� .+��� $
 Border��$ 	20 10 5 5q�$��1q�#��z��#��z��._��� $ PART_ContentHost��$��0q���  .  #��z $ 	60 15 5 5q����� " ��.���  � y�$ 	Collapsed=���  � �� �#EFEEEF��  � ��$ Segoe UI)���  � ��$
 15px(� ��  �� *Text+ �� *TemplatedParent+  .a���  � y�$ Visible=��� " ��.���  � �� �#6783B8��  � �� �� "	 ��.R��� $��0q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.7Q�P�  �@�Tag$ Valyuta��. ���  � �� �#FFFFEF�� " ��.���  � �� �#283654��  � ��$ Segoe UI)���  � ��$
 20px(���  � �� �� "	 ��.R�� .+�d� $��2��|�.   �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+���� .R��  �� $��5* ��� $��* �.+��� $
 Border��$��2��$ 5 0 0 5�����#FFFFFF���#4D638C$��1q��� $��0��$ 5,0,0,5��$��1q����#FFFFFF���#4D638C$��0,0,0,0q�F� $ Arrow��$��1�����#283654$��Center=�$��Center=�"����        � 	=  	= � z     	 P�  �@J�IsMouseOver . . ��� $ Border�� � �� �#FFFFEFP�  �@d�	IsChecked$
 trueY�. ��� $ Border�� � �� �#FFFFEF�� $��ContentSite�� .  #��z #��z #��z��$��3q�$��Center=�$��Center=��� $  PART_EditableTextBox��$y�Hidden=�#" z! � $��Popup��$��Bottom=�#��z# $ . |�.  $��Slide=�.��� $��DropDown��% . #��z& #��z' .+��� $
 DropDownBorder�����#FFFFEF�� % . .���� ( .  .���� $��1q����#C4C4C4._�� $��1��
�������) � RowDefinitions) �� $	��100 ��� $	��208 ��� .+�� $��0��.+��� $��To'lov oynasi��$��Segoe UI)�$
��40px(����#4D638C$��SemiBold"�$��Center=�$��Center=��� -   * ��Name$* btnClose��$	��Top=�$��
0 14 14 14q�+ � Cursor$
+ Hand��.���� $��../Images/Close.png��$��30��$��30������ " ��.���  � ��$ 35����  � ��$ 35����  � ��$ 	0 15 20 0q���  � ��$ Right=���  � ��
 �������  � ��
 �������  � �� �� "	 ��.R��� #��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � ��
 ������ $��1��) �� �� .+�� $��0��) �� $��15 ��� $��65 �.+�� $��0�� �� $	��270 ��� $��* �.+��� $��0��$��Qarzdorlik so'm�����#283654$
��12px(�$��72 0 0 0q�$��SemiBold"��� $��1��$��Qarzdorlik dolar�����#283654$
��12px(�$��0 0 0 0q�$��SemiBold"�$
��Left=��� $��1��, �� Orientation$, 
Horizontal=�.+��� $	��206��$��52��$��53 0 0 0q�$ 5 0 0 5��$��1q����#283654._��� -   - ��Name$- txtCurrency1��$��Segoe UI)�$
��20px(�$��Bottom=����#283654$��SemiBold"�$��	20 5 0 10q��� ��� *	Total_sum+�� $ 0 5 5 0��$��0 1 1 1q����#283654$	��333��$��52��._��  �� �� .+��� $��0��$
��20px(�$��Segoe UI)����#283654$��Center=�$��	20 0 10 0q����� $ Total_dollar��� -   $- txtCurrency��$��1��$��Segoe UI)�$
��14px(�$��Bottom=����#283654$��SemiBold"�$��	10 0 0 10q�y��� $ CurrencyVisibility�$ TwoWay=��� $�kursi: �� �� ��� $ Currency�$ TwoWay=�� $��1��) �� $��15 ��� $��65 �.+�� $��0�� �� $	��270 ��� $��* �.+��� $��0��$��To'lov turi�����#283654$
��12px(�$��72 0 0 0q�$��SemiBold"��� $��1��$��To'lov summasi:�����#283654$
��12px(�$��0 0 0 0q�$��SemiBold"�$
��Left=��� $��1��$, 
Horizontal=�.+��� -   . ��Name$. comboCurrency��#��[ $	��207��$��51��$��49 0 0 0q�/ �� Text/ �� $ PaymentType�$ OneWayToSource=�0 �� SelectedIndex0 �� $ PaymentType�$ OneWayToSource=�.@��� .���� $, 
Horizontal=�.+��� $��As.y kassa uz���� $��../Images/PavCash.png��$��20��$��25��$��8 0 0 0q��� .���� $, 
Horizontal=�.+��� $��As.y kassa $���� $��../Images/PavCash.png��$��20��$��25��$��8 0 0 0q��� .���� $, 
Horizontal=�.+��� $��Plastik karta���� $��../Images/Pavcard.png��$��20��$��25��$��8 0 0 0q��� .���� $, 
Horizontal=�.+��� $	��X/R���� $��../Images/PavTransfer.png��$��20��$��25��$��8 0 0 0q��� -   $  txtPayedSumma��$	��281��$��51��$��0 1 1 1q����#283654$
��20px(����#283654$��
20 10 10 0q�1 �� 
CaretBrush1 �#283654.������ $ 
PayedSumma�2 �� UpdateSourceTrigger$2 PropertyChanged=�.��3 J� InputBindings3 �� 
4 �� Key$4 Return��5 �� Command5 �� *SubmitPaymentCommand+.���� $
+ Hand������ *SubmitPaymentCommand+.���� $��../Images/+.png��$��20��$��20������ " ��.���  � ��$ 48����  � ��$ 51����  � ��
 �������  � �� �� "	 ��.R��� $ 0 5 5 0��$��0 1 1 1q����#283654#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �#FFFFEF� $��2��) �� $��30 ��� $��* �.+�� $��0��.+��� $��Segoe UI)�$��20(����#4D638C$��SemiBold"�$��Center=�$��	49 0 20 0q��� $�	Mijoz:   �� �� ��� *Client_name+� $��1��$��	45 0 25 0q� �� $	��205 ��� $��* �.+��� -   $��0������ *FinalizePaymentCommand+.���� $��To'lov��$��	Segoue UI)�$
��50px(�
����������� " ��.���  � �� �#4D638C��  � ��$	 144����  � �� �� "	 ��.R��� $ 5 0 0 5��$��1q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q���  � ��$ DemiBold"��� $��1��$ 0 5 5 0��$��0 1 1 1q����#283654$	��144��._��� $��Center=�.+��� -   $
 	stackNaqd��$��0 0 0 1q����#283654y��� $ CashSumVisibility�._��� $, 
Horizontal=�.+��� $��../Images/PavCash.png��$��20��$��25��$��8 0 0 0q��� $��uz��$��Center=�$��5 0 0 0q�$
��14px(��� $	��253��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *	CashSum+��   	btnSearch#��[ $��0q�$��30������ *ClearCashSumCommand+.���� $��../Images/x.png��$��15���� -   $
 stackNaqddollar��$��0 0 0 1q����#283654y��� $ CashDollarVisibility�._��� $, 
Horizontal=�.+��� $��../Images/PavCash.png��$��20��$��25��$��8 0 0 0q��� $��$��$��Center=�$��5 0 0 0q�$
��14px(��� $	��258��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *
CashDollar+�� #��[ $��0q�$��30������ *ClearCashDollarCommand+.���� $��../Images/x.png��$��15���� -	   $
 stackPlastik��$��0 0 0 1q����#283654y��� $ CreditCardVisibility�._��� $, 
Horizontal=�.+��� $��../Images/PavCard.png��$��20��$��25��$��8 0 0 0q��� $	��270��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *
CreditCard+�� #��[ $��0q�$��30������ *ClearCreditCardCommand+.���� $��../Images/x.png��$��15���� -
   $
 stackXR��$��0 0 0 1q����#283654y��� $ TransferVisibility�._��� $, 
Horizontal=�.+��� $��../Images/PavTransfer.png��$��20��$��25��$��8 0 0 0q��� $	��270��$
��Left=�$��33��$��Segoe UI)�$
��20px(�$ 20 2 0 0q����� *
Transfer+�� #��[ $��0q�$��30������ *ClearTransferCommand+.���� $��../Images/x.png��$��15��� $��2��$	��100��$	��100��$��
0 -300 0 0q�y��� *LoadingVisibility+��!� 6 !� Visual6 �� "  WpfAnimatedGif.ImageBehavior7   AnimatedSource$ 7 /Views/Loading/loading.gif��8   	AutoStart8 . 9   RepeatBehavior$9 1��