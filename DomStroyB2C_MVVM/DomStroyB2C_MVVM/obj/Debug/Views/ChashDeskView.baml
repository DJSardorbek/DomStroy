   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      K GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views 5      *   $DomStroyB2C_MVVM.Views.ChashDeskView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      6local$clr-namespace:DomStroyB2C_MVVM.Views     5      .��5
      � ���#E5E5E5  � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#4D638C.+�5      �� -   5        $	��200��5      $
��Left=�6!   $��Print��5      5      �� 5      -   5         ��Name$ 	txtSearch��5      
 � Tag$ 	Izlash...��6)      	txtSearch#��[  69   $	��564��5      $��34��6"   $��Center=�6.   $��Right=�6I   $��0 0 20 0q�5      .��6)   5      �� 5      $��../Images/search.png��6   $��20��62   $��20��6>   $��Center=�5      $��Right=�6/   $��0 0 35 0q�5      5      � 5"   
   $��1��6   .+�5#      �� -   5         ��Name$ scrollViewer��5#      $��Disabled=�61   ��5$      �� 5%       �� 
TargetType" ��6    �� Triggers 5&      �� 5'       �� Binding 6*   �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False6]   .a�5(   "   �� 	 �� Property	 � ��
 �� Value$

 Auto=�6P   5)      5+      .��5-      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridCash��5-      $y�Visible=�61   $   HorizontalScrollBarVisibility$
 Auto=�5.      $
��Auto��5/         HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�52         CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��20q�5:      $��1q�5;         SelectionMode$ Single=�6/      SelectionUnit$ FullRow=�5<       �� AlternationCount$ 2��5=      ��5>      ��  �� Path$ ShopList� �� Mode$ TwoWay=� �� SelectedItem 5?      �� $
 Shop�$ TwoWay=� � 	Resources 5A        MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader  �� 
TargetType! �� CornerRadius��%�  '        7  '  i     7  '      '      7  '�� �    �� 5B      "  6    8   .�5C      �� 	 �@ GridLinesVisibility$
 
Horizontal=�6D   5D      �� 5E      "  6    8   .�5F      �� 	 �@�FocusVisualStyle
 6A   Z� �� 5H      	 � ��
 �#7A79796;   �� 5I      	 � ��$
 0q�6@   �� 5J      	 � ��$
 50��67   �� 5L      	 �@��TextAlignment$
 Center=�6H   �� 5M      	 � ��$
 Center=�6B    5N      P� 5O   "    �@ 
IsSelected . . �5P   &   �� 	 � ��
 �#B6E0FF6C   5Q   #   5T      �� 5W      "  6     5X      P� 5Y   "    �@ AlternationIndex$ 0��6F   . �5Z   &   �� 	 � ��
 �#FFFFFF6C   5[   #   P� 5\   "    �@ AlternationIndex$ 1��6F   . �5]   &   �� 	 � ��
 �#E3E2E26C   5^   #   5`      �� 5c      "  6    8   .�5d      �� 	 � ��
 �#2836546;   �� 5e      	 � ��

 �����6;   �� 5f      	 � ��$
 55��67   �� 5g      	 � ��$
 Center=�6K   �� 5h      	 � ��$
 Center=�6I   �� 5i      	 � ��$
 30 0 0 0q�68   �� 5j      	 � ��
 5k   "   �� 5l   &   "   66   .R�5m   *   �� $! 	10 10 0 0��5n   -   #��z��5o   -   #��z��5p   -   ._�5q   .   �� $��Center=�6?   $��Center=�6Z   5r   +   5s   '   5u       5v      5y      �� 5{      " ��6    .�5|      �� 	 � ��
 �#2638596;   5}      5~      "   Columns" 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn#   Header$
# Chek��6-   $   
IsReadOnly$ . %   Width5  /System.Windows.Controls.DataGridLengthConverter$% 80 6d   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 6;   �� *Id+6d     5�      $
# Izoh��6-   $ . $
% 150* 6i   & 6;   �� *	Comment+6i     5�      $# Sotuvchi��6-   $ . $
% 150* 6l   & 6?   �� *Seller+6l     5�      $# 
Summa so'm��6-   $ . $	% 150 6n   & 6A   �� *SumSom+6n     5�      $# Summ dollar��6-   $ . $	% 150 6r   & 6B   �� *	SumDollar+6r     5�      $
# Sana��6-   $ . $
% 150* 6f   & 6;   �� *Date+6f   4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      # 5�      �� 5�   "   $��To'lov��6,   $
��120 ��6:   
�������$��Segoe UI)�6Z   $��15(�6p   ' �� TextAlignment$' Center=�6~   ( 	  CellTemplate( 5�      �� 5�   "   .R�5�   &   ��   btnPlus#��[ 6-   $	��100��6N   .
   (System.Windows.Interactivity.Interaction) 
  Triggers) 5�   *   /   )System.Windows.Interactivity.EventTrigger  5�   .   *   	EventName$* Click��6=   .   (System.Windows.Interactivity.TriggerBase+   Actions.+ 5�   2   6   0System.Windows.Interactivity.InvokeCommandAction  ,   Command, 6H   �� - �� RelativeSource- �� . �� AncestorType". >�$$ DataContext.OpenPaymentCommand�5�   /   .��5�   *   �� $��../Images/Pay.png��60   $��20��6K   $��20��6V   5�   '   5�   #   5�      	  5�      # 5�      �� 5�   "   $��Bekor qilish��6,   $
��120 ��6@   
�������$��Segoe UI)�6`   $��15(�6v   $' Center=�6�   ( 5�      �� 5�   "   .R�5�   &   ��   	btnCancel#��[ 6-   $	��100��6P   ��5�   -   �� - �� ". >�$# DataContext.CancelShopCommand�.��5�   *   �� $!��../Images/cancelRecieve.png��60   $��20��6U   $��20��6`   5�   '   5�   #   5�      5�      5�      5�      5�      5�      