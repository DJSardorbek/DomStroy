   M S B A M L   `   `   `  ����K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  5      /    )DomStroyB2C_MVVM.Views.RecieveFakturaView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:DomStroyB2C_MVVM.Views     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5      ���#E5E5E5  � 	Resources  5
       �� 
TargetType   txtBlockMenu �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��$ Segoe UI)�6+   �� 5       � ��$
 10px(�6)   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#4D638C.+�5      �� -   5         ��Name$ 	txtSearch��5      
 � Tag$ 	Izlash...��6)     	txtSearch#��[ 69   $	��564��5      $��34��6"   $��Center=�6.   $��Right=�6I   $��0 0 20 0q�5      .��6)   5      �� 5       $��../Images/search.png��6   $��20��62   $��20��6>   $��Center=�5!      $��Right=�6/   $��0 0 35 0q�5"      5$      � 5)   
   $��1��6   .+�5+      �� -   5         ��Name$ scrollViewer��5+      $��Disabled=�61   ��5,      �� 5-      " ��6    �� Triggers 5.      �� 5/      	 �� Binding	 6*   �� *
HasItems+
 �� ElementName$
 dataGrid�� �� Value	 False6]   .a�50   "   ��  � ��$
 Auto=�6P   51      53      .��55      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridFaktura��55      $y�Visible=�68   $   HorizontalScrollBarVisibility$
 Auto=�56      $
��Auto��57         HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�5:         CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��20 20 20 20q�5B      $��1q�5C         SelectionMode$ Single=�6)      SelectionUnit$ FullRow=�5D       �� AlternationCount$ 2��5E      ��5F      ��  �� Path$ InvoiceList.results� �� Mode$ TwoWay=� �� SelectedItem 5G      �� $ Invoice�$ TwoWay=�  5I        MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader  �� 
TargetType! �� CornerRadius��%�  '        7  '  i     7  '  �    '      7  '��     �� 5J      "  6    8   .�5K      ��  �@ GridLinesVisibility$ 
Horizontal=�6D   5L      �� 5M      "  6    8   .�5N      ��  �@�FocusVisualStyle 6A   Z� �� 5P       � �� �#7A79796;   �� 5Q       � ��$ 0q�6@   �� 5R       � ��$ 50��67   �� 5T       �@��TextAlignment$
 Left=�6H   �� 5U       � ��$ Center=�6B    5V      P� 5W   "    �@ 
IsSelected . . �5X   &   ��  � �� �#B6E0FF6C   5Y   #   5\      �� 5_      "  6     5`      P� 5a   "    �@ AlternationIndex$ 0��6F   . �5b   &   ��  � �� �#FFFFFF6C   5c   #   P� 5d   "    �@ AlternationIndex$ 1��6F   . �5e   &   ��  � �� �#E3E2E26C   5f   #   5h      �� 5k      "  6    8   .�5l      ��  � �� �#2836546;   �� 5m       � ��
 �����6;   �� 5n       � ��$ 55��67   �� 5o       � ��$ Center=�6K   �� 5p       � ��$ Center=�6I   �� 5q       � ��$ 30 0 0 0q�68   �� 5r       � �� 5s   "   �� 5t   &   "   66   .R�5u   *   �� $! 	10 10 0 0��5v   -   #��z��5w   -   #��z��5x   -   ._�5y   .   �� $��Center=�6?   $
��Left=�6Z   $��15 0 0 0q�6u   5z   +   5{   '   5}       5~      5�      �� 5�      " ��6    .�5�      ��  � �� �#2638596;   5�      5�      "   Columns" 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn#   Header$# Faktura nomi��6-   $   
IsReadOnly$ . %   Width5  /System.Windows.Controls.DataGridLengthConverter$
% 180* 6n   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 6C   �� *name+6n     5�      $# Filial/ Ombor��6-   $ . $
% 180* 6{   & 6D   �� *from_branch.name+6{     5�      $
# Sana��6-   $ . $
% 180* 6l   & 6;   �� *
created_at+6l     5�      $# Summa so'mda��6-   $ . $
% 120* 6s   & 6C   �� *	summa_sum+6s     5�      $# Summa dollarda��6-   $ . $
% 120* 6y   & 6E   �� *summa_dollar+6y   4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      # 5�      �� 5�   "   $��Ko'rish��6,   $
��100 ��6;   
�������$��Segoe UI)�6[   $��15(�6q   ' �� TextAlignment$' Center=�6   $��	-15 0 0 0q�6�   ( 	  CellTemplate( 5�      �� 5�   "   .R�5�   &   ��  
 btnSee#��[ 6-   ��5�   -   �� ) �� RelativeSource) �� * �� AncestorType"* >�$( "DataContext.OpenInvoiceItemCommand�.��5�   *   �� $��../Images/seeRecieve.png��60   $��25��6R   $��25��6]   5�   '   5�   #   5�      	  5�      # 5�      �� 5�   "   $��Bekor��6,   $
��100 ��69   
�������$��Segoe UI)�6Y   $��15(�6o   $' Center=�6}   $��	-15 0 0 0q�6�   ( 5�      �� 5�   "   .R�5�   &   ��   	btnCancel#��[ 6-   ��5�   -   �� ) �� "* >�$&  DataContext.CancelInvoiceCommand�.��5�   *   �� $!��../Images/cancelRecieve.png��60   $��20��6U   $��20��6`   5�   '   5�   #   5�      5�      5�      5�      � 5�   
   $��1��6   $	��200��6   $	��200��6(   $��	0 -50 0 0q�65   y�5�      �� *LoadingVisibility+��5�      !� 5�      + !� Visual+ 5�      �� 5�      "
  WpfAnimatedGif.ImageBehavior, 
  AnimatedSource$ , /Views/Loading/loading.gif��6    - 
  	AutoStart- . . 
  RepeatBehavior$. 1��5�      5�      5�      5�      5�      