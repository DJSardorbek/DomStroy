   M S B A M L   `   `   `  ����K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  5      I)clr-namespace:DomStroyB2C_MVVM.ViewModelsDomStroyB2C_MVVM.ViewModels  5      b ^Syncfusion.SfChart.WPF, Version=19.2460.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts 5      1    +DomStroyB2C_MVVM.Views.TovarAnalizChartView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:DomStroyB2C_MVVM.Views     5      8vm)clr-namespace:DomStroyB2C_MVVM.ViewModels     5      YchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF     5        � DataContext  5      ;  5DomStroyB2C_MVVM.ViewModels.TovarAnalizChartViewModel  5   
   .��5      � ���#EDEDED � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��130 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#4D638C.+�5      �� $
��Sale��6;   ��6   �� *UpdateViewCommand+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 40��62   �� 5       � ��$ 40��63   �� 5       � ��
 ���� 67   �� 5       � ��$
 Left=�6@   �� 5       � ��$ 25 0 0 0q�63   �� 5        � �� 5!      �� 5"   "    �� 
TargetType" ��62   .R�5#   &   �� #��z��5$   )   #��z��5%   )   ._�5&   *   �� $��Center=�6;   $��Center=�6V   5'   '   5(   #   5*       �� Triggers 5+      P� 5,       P� Property �@J�IsMouseOver P� Value . . �5-   "   ��  � �� �#2836546?   �� 5.   "    � �� �#2836546@   5/      51      .��53      �� $��../Images/imageback.png��6   $��30��69   $��30��6D   54      55      � 58   
   $��1��6   .+�59      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataGridSumma��59      $y�Visible=�6.   $
   HorizontalScrollBarVisibility$

 Auto=�5:      $
��Auto��5;         HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$	 All=�5>         CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�5F         SelectionMode$ Single=�6)      SelectionUnit$ FullRow=�6@    �� AlternationCount$ 2��5G      $��
80 20 80 0q�5H       � 	Resources 5I         MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� CornerRadius��%�  '        7   '  i     7  '  w    '  y    7  '�� r    �� 5J      "  6   8   .�5K      ��  �@ GridLinesVisibility$ 
Horizontal=�6@   5L      �� 5M      "  6   8   .�5N      ��  �@�FocusVisualStyle 6=   Z� �� 5O       � �� �#FFFFFF67   �� 5P       � �� �#7A797967   �� 5Q       � ��$ 0q�6<   �� 5R       � ��$ 50��63   �� 5S       � ��$ SemiBold"�67   �� 5T       � ��$ 16(�65   �� 5U       � �� �#26385968   �� 5V       �@��TextAlignment$ Center=�6D    5W      P� 5X       �@ 
IsSelected . . �5Y   "   ��  � ��
 �����6?   5Z      5]      �� 5`      "  6    5a      P� 5b       �@ AlternationIndex$ 0��6B   . �5c   "   ��  � �� �#FFFFFF6?   5d      P� 5e       �@ AlternationIndex$ 1��6B   . �5f   "   ��  � �� �#E3E2E26?   5g      5i      �� 5l      "  6   8   .�5m      ��  � �� �#28365467   �� 5n       � ��
 �����67   �� 5o       � ��$ 42��63   �� 5p       � ��$ Center=�6G   �� 5q       � ��$ Center=�6E   �� 5r       � ��$ 30 0 0 0q�64   �� 5s       � �� 5t      �� 5u   "   "  62   .R�5v   &   �� $ 	10 10 0 0��5w   -   #��z��5x   -   #��z��5y   -   ._�5z   *   �� $��Center=�6;   $��Center=�6V   5{   '   5|   #   5~       5      5�      �� 5�      " ��6   .�5�      ��  � �� �#26385967   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Maxsulot nomi��6)      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 150* 6o   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6@   �� *
naqd_som+6o     5�      $ Ishlab chiqaruvchi��6)    . $
 150* 6w    6E   �� *naqd_dollar+6w     5�      $ O'lchov birligi��6)    . $
 150* 6p    6B   �� *	plastik+6p   5�      5�      )
  #Syncfusion.UI.Xaml.Charts.SfChart3D
  5�   
   ���#E8E8E8���#283654$��2��5�      $��40 10 40 10q�6    
  BackWallBrush �#E8E8E8  
  LeftWallBrush  �#E8E8E8! 
  PrimaryAxis! 5�      .  (Syncfusion.UI.Xaml.Charts.CategoryAxis3D  5�      " 
  SecondaryAxis" 5�      /  )Syncfusion.UI.Xaml.Charts.NumericalAxis3D  5�      # 
  Series.# 5�      .  (Syncfusion.UI.Xaml.Charts.ColumnSeries3D  /  )Syncfusion.UI.Xaml.Charts.ChartSeriesBase$   ShowTooltip$ . %   XBindingPath$% month��5�   #   .  (Syncfusion.UI.Xaml.Charts.XyDataSeries3D&   YBindingPath$& amount��5�   #   '   Palette$' 
BlueChrome=�5�   #   (   ItemsSource( 5�   6   �� *
Products+-  'Syncfusion.UI.Xaml.Charts.ChartSeries3D)   AdornmentsInfo) 5�      4  .Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo3D  5�      6  0Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase*   	ShowLabel* . +   Symbol$+ Diamond=�5�   1   ,   
Background
, ���� 6B   5�      5�      5�      5�      