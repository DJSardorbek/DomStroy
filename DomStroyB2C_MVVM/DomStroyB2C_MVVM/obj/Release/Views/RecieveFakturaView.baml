   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  /    )DomStroyB2C_MVVM.Views.RecieveFakturaView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  ���#E5E5E5  � 	Resources   �� 
TargetType   txtBlockMenu �� Property �� Value��%c   &	        �� " ��.���  � ��$ Segoe UI)���  � ��$
 10px(���  � ��
 �����.���  � RowDefinitions �� $��50 ��� $��* �.+�� $��0�����#4D638C.+��� -    ��Name$ 	txtSearch��
 � Tag$ 	Izlash...��  	txtSearch#��[ $	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q�.���� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q�� $��1��.+��� -    ��Name$ scrollViewer��$��Disabled=����� " �� �� Triggers �� 	 �� Binding	 �� *
HasItems+
 �� ElementName$
 dataGrid�� �� Value	 False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -     Name$ dataGridFaktura��$y�Visible=�$   HorizontalScrollBarVisibility$
 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��20 20 20 20q�$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2������  �� Path$ InvoiceList.results� �� Mode$ TwoWay=� �� SelectedItem �� $ Invoice�$ TwoWay=�    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell P� Property P� Value)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader  �� 
TargetType! �� CornerRadius��%e  '        7  '  D     7  '  F    '  �    7  '�� �    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  �@��TextAlignment$
 Left=���  � ��$ Center=� P�  �@ 
IsSelected . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "   .R��� $! 	10 10 0 0��#��z��#��z��._��� $��Center=�$
��Left=�$��15 0 0 0q� �� " ��.���  � �� �#263859"   Columns" 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn#   Header$# Faktura nomi��$   
IsReadOnly$ . %   Width5  /System.Windows.Controls.DataGridLengthConverter$
% 180* 1  +System.Windows.Controls.DataGridBoundColumn&   Binding& �� *name+  $# Filial/ Ombor��$ . $
% 180* & �� *from_branch.name+  $
# Sana��$ . $
% 180* & �� *
created_at+  $# Summa so'mda��$ . $
% 120* & �� *get_item_sum+  $# Summa dollarda��$ . $
% 120* & �� *get_item_dollar+4	  .System.Windows.Controls.DataGridTemplateColumn	  # �� $��Ko'rish��$
��100 ��
�������$��Segoe UI)�$��15(�' �� TextAlignment$' Center=�$��	-15 0 0 0q�( 	  CellTemplate( �� .R���  
 btnSee#��[ ���� ) �� RelativeSource) �� * �� AncestorType"* >�$( "DataContext.OpenInvoiceItemCommand�.���� $��../Images/seeRecieve.png��$��25��$��25��	  # �� $��Qabul��$
��100 ��
�������$��Segoe UI)�$��15(�$' Center=�$��	-15 0 0 0q�( �� .R���   btnPlus#��[ ���� ) �� "* >�$' !DataContext.RecieveInvoiceCommand�.���� $��../Images/prRecieve.png��$��25��$��25��	  # �� $��Bekor��$
��100 ��
�������$��Segoe UI)�$��15(�$' Center=�$��	-15 0 0 0q�( �� .R���   	btnCancel#��[ ���� ) �� "* >�$&  DataContext.CancelInvoiceCommand�.���� $!��../Images/cancelRecieve.png��$��20��$��20��� $��1��$	��200��$	��200��$��	0 -50 0 0q�y��� *LoadingVisibility+��!� + !� Visual+ �� "
  WpfAnimatedGif.ImageBehavior, 
  AnimatedSource$ , /Views/Loading/loading.gif��- 
  	AutoStart- . . 
  RepeatBehavior$. 1��