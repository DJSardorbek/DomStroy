   M S B A M L   `   `   `  ����K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  5      ,    &DomStroyB2C_MVVM.Views.BuyurtmalarView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0local$clr-namespace:DomStroyB2C_MVVM.Views  5      .��5
      � ���#EDEDED  � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� $	��250��6   $��35��6#      ComboBoxTest2#��[  6/   $
��Left=�6V   $��	10 10 0 0q�5      5      � 5   
   $��1��6   .+�5      �� -   5         ��Name$ scrollViewer��5      $��Disabled=�61   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6*   �� *
HasItems+ �� ElementName$ dataGrid�� �� Value	 False6]   .a�5   "   ��  �� Property � �� �� Value$
 Auto=�6P   5      5       .��5"      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataGridOrders��5"      $y�Visible=�63   $
   HorizontalScrollBarVisibility$

 Auto=�5#      $
��Auto��5$         HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�5'         CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��10q�5/      $��1q�50         SelectionMode$ Single=�6)      SelectionUnit$ FullRow=�6@    �� AlternationCount$ 2��51       � 	Resources 53        MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� 
TargetType �� CornerRadius��%�  '        7  '  i     7  '      '      7  '�� �    �� 54      "  6    8   .�55      ��  �@ GridLinesVisibility$ 
Horizontal=�6D   56      �� 57      "  6    8   .�58      ��  �@�FocusVisualStyle 6A   Z� �� 5:       � �� �#7A79796;   �� 5;       � ��$ 0q�6@   �� 5<       � ��$ 50��67   �� 5>       �@��TextAlignment$ Center=�6H   �� 5?       � ��$ Center=�6B    5@      P� 5A   "    �@ 
IsSelected . . �5B   &   ��  � �� �#B6E0FF6C   5C   #   5F      �� 5I      "  6     5J      P� 5K   "    �@ AlternationIndex$ 0��6F   . �5L   &   ��  � �� �#FFFFFF6C   5M   #   P� 5N   "    �@ AlternationIndex$ 1��6F   . �5O   &   ��  � �� �#E3E2E26C   5P   #   5R      �� 5U      "  6    8   .�5V      ��  � �� �#2836546;   �� 5W       � ��
 �����6;   �� 5X       � ��$ 55��67   �� 5Y       � ��$ Center=�6K   �� 5Z       � ��$ Center=�6I   �� 5[       � ��$ 30 0 0 0q�68   �� 5\       � �� 5]   "   �� 5^   &   "  66   .R�5_   *   �� $ 	10 10 0 0��5`   -   #��z��5a   -   #��z��5b   -   ._�5c   .   �� $��Center=�6?   $��Center=�6Z   5d   +   5e   '   5g       5h      5k      �� 5m      " ��6    .�5n      ��  � �� �#2638596;   5o      5p         Columns 5r      0  *System.Windows.Controls.DataGridTextColumn  5s      ,  &System.Windows.Controls.DataGridColumn   Header$ Filial��6-      
IsReadOnly .     Width5  /System.Windows.Controls.DataGridLengthConverter$
  150* 6j   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6=   �� *branch+6j     5t      $ Sotuvchi��6-    . $
  130* 6k   ! 6?   �� *saler+6k     5u      $ Mijoz��6-    . $
  130* 6i   ! 6<   �� *client+6i     5v      $ Telefon raqami��6-    . $
  130* 6q   ! 6E   �� *phone+6q     5w      $
 Sana��6-    . $
  130* 6f   ! 6;   �� *date+6f     5x      $ Summa dollarda��6-    . $
  100* 6r   ! 6E   �� *dollar+6r     5y      $ Summa somda��6-   $
  100* 6Z    . ! 6B   �� *som+6g     5z      $ To'lov turi��6-   $
  100* 6Z    . ! 6B   �� *tul+6g   4	  .System.Windows.Controls.DataGridTemplateColumn	  5{       5|      �� 5}   "   $��Korzinkaga olish��6,   $
��130 ��6D   
�������$��Segoe UI)�6d   $��15(�6z   " �� TextAlignment$" Center=�6�   # 	  CellTemplate# 5      �� 5�   "   .R�5�   &   ��   btnPlus#��[ 6-   .��5�   *   '
  !MaterialDesignThemes.Wpf.PackIcon
  $ 
  Kind$
$ Plus=�6B   
�������$��25��6a   $��25��6l   5�   '   5�   #   5�      	  5�       5�      �� 5�   "   $��Bekor qilish��6,   $
��100 ��6@   
�������$��Segoe UI)�6`   $��15(�6v   $" Center=�6�   # 5�      �� 5�   "   .R�5�   &   ��   	btnCancel#��[ 6-   .��5�   *   �� $!��../Images/cancelRecieve.png��60   $��20��6U   $��20��6`   5�   '   5�   #   5�      5�      5�      5�      5�      5�      