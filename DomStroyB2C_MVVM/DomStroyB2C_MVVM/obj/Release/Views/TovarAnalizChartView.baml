   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views  I)clr-namespace:DomStroyB2C_MVVM.ViewModelsDomStroyB2C_MVVM.ViewModels  b ^Syncfusion.SfChart.WPF, Version=19.2460.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts 1    +DomStroyB2C_MVVM.Views.TovarAnalizChartView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:DomStroyB2C_MVVM.Views     8vm)clr-namespace:DomStroyB2C_MVVM.ViewModels     YchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF       � DataContext  ;  5DomStroyB2C_MVVM.ViewModels.TovarAnalizChartViewModel  .��� ���#EDEDED � RowDefinitions �� $��50 ��� $	��130 ��� $��* �.+�� $��0�����#4D638C.+��� $
��Sale������ *UpdateViewCommand+����  �� 
TargetType" ��.���  �� Property � �� �� Value$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� ��  �� 
TargetType" ��.R��� #��z��#��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30��� $��1��.+�&   System.Windows.Controls.DataGrid  -   	  Name$	 dataGridSumma��$y�Visible=�$
   HorizontalScrollBarVisibility$

 Auto=�$
��Auto��   HorizontalGridLinesBrush �#E3E2E2   AutoGenerateColumns .     GridLinesVisibility$	 All=�   CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .  ���#FFFFFF$��1q�   SelectionMode$ Single=�   SelectionUnit$ FullRow=� �� AlternationCount$ 2��$��
80 20 80 0q� � 	Resources    MaterialDesignDataGrid �� BasedOn*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader �� CornerRadius��%�  '        7   '  D     7  '  �    '  ,    7  '�� ?    �� "  8   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8   .���  �@�FocusVisualStyle Z� ��  � �� �#FFFFFF��  � �� �#7A7979��  � ��$ 0q���  � ��$ 50����  � ��$ SemiBold"���  � ��$ 16(���  � �� �#263859��  �@��TextAlignment$ Center=� P�  �@ 
IsSelected . . ���  � ��
 ������� "   P�  �@ AlternationIndex$ 0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$ 1��. ���  � �� �#E3E2E2�� "  8   .���  � �� �#283654��  � ��
 �������  � ��$ 42����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $ 	10 10 0 0��#��z��#��z��._��� $��Center=�$��Center=� �� " ��.���  � �� �#263859   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Maxsulot nomi��   
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 150* 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *
naqd_som+  $ Ishlab chiqaruvchi�� . $
 150*  �� *naqd_dollar+  $ O'lchov birligi�� . $
 150*  �� *	plastik+)
  #Syncfusion.UI.Xaml.Charts.SfChart3D
  ���#E8E8E8���#283654$��2��$��40 10 40 10q� 
  BackWallBrush �#E8E8E8  
  LeftWallBrush  �#E8E8E8! 
  PrimaryAxis! .  (Syncfusion.UI.Xaml.Charts.CategoryAxis3D  " 
  SecondaryAxis" /  )Syncfusion.UI.Xaml.Charts.NumericalAxis3D  # 
  Series.# .  (Syncfusion.UI.Xaml.Charts.ColumnSeries3D  /  )Syncfusion.UI.Xaml.Charts.ChartSeriesBase$   ShowTooltip$ . %   XBindingPath$% month��.  (Syncfusion.UI.Xaml.Charts.XyDataSeries3D&   YBindingPath$& amount��'   Palette$' 
BlueChrome=�(   ItemsSource( �� *
Products+-  'Syncfusion.UI.Xaml.Charts.ChartSeries3D)   AdornmentsInfo) 4  .Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo3D  6  0Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase*   	ShowLabel* . +   Symbol$+ Diamond=�,   
Background
, ���� 