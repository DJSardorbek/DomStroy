   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  K GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DomStroyB2C_MVVM.ViewsDomStroyB2C_MVVM.Views (   "DomStroyB2C_MVVM.Views.ClientOrder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9System&clr-namespace:System;assembly=mscorlib     6local$clr-namespace:DomStroyB2C_MVVM.Views     @
extensions)using:Microsoft.Toolkit.Uwp.UI.Extensions     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  UwpfxJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended    � 	Resources     DatePickerStyle1 �� 
TargetType(  "System.Windows.Controls.DatePicker �� Property �� Value �� RelativeSource �� AncestorLevel �� AncestorType&   System.Windows.Controls.Calendar  MaterialDesignBody  MaterialDesignPaper:  4System.Windows.Controls.Primitives.CalendarDayButton �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup	   Transitions%  System.Windows.VisualTransition
   GeneratedDuration   From   GeneratedEasingFunction   
Storyboard	   To   States   System.Windows.VisualState   
Storyboard g� Duration	 W� To �� TargetProperty �� 
TargetName g� FillBehavior R� KeyTime   PrimaryHueMidForegroundBrush R� Value  System.Windows.Visibility A�Name J� Opacity  PrimaryHueMidBrush ��Name  PrimaryHueDarkBrush ��Name �� ContentStringFormat �� ContentStringFormat �� Triggers P� Property  P� Value7	  1System.Windows.Controls.Primitives.CalendarButton  PrimaryHueLightBrush! J� 	CacheMode  MaterialDesignShadowDepth4" J� Effect# �� Padding5
  /System.Windows.Controls.Primitives.CalendarItem$ 
 Name-  'MaterialDesignThemes.Wpf.CalendarAssist%   IsHeaderVisible & "MaterialDesignCalendarItemPortrait 	 MaterialDesignTextBoxBorder.  (MaterialDesignThemes.Wpf.TextFieldAssist)  #MaterialDesignThemes.Wpf.HintAssist& � 	Resources 
 Key'  !MaterialDesignThemes.Wpf.PackIcon'   Kind( �Name:  4System.Windows.Controls.Primitives.DatePickerTextBox)  Name*   DecorationVisibility+   FloatingScale,   
Foreground-   FloatingOffset.   HasOutlinedTextField/   HasFilledTextField0   Hint1   HelperTextFontSize2   HintOpacity3   
HelperText4   HasClearButton5   
IsFloating!6   NewSpecHighlightingEnabled7   
PrefixText8   RippleOnFocusEnabled # MaterialDesignDatePickerTextBox9   
SuffixText:   TextFieldCornerRadius;   TextBoxViewMargin<   UnderlineBrush=   UnderlineCornerRadius> `� UpdateSourceTrigger? `� 	ConverterE  ?MaterialDesignThemes.Wpf.Converters.PickerInnerPaddingConverter@ �� PathA �� ElementNameB �� ModeC ��NameD �� PropertyE �� 	ConverterF �NameG � AllowsTransparency#H � CustomPopupPlacementCallbackI � 	StaysOpenJ �� Triggers ( $MaterialDesignTextFieldBoxBackground   MaterialDesignTextAreaBorderK ]� 
ConditionsL �� PropertyM �� ValueN �� 
SourceNameO �� 
TargetName ( $MaterialDesignTextAreaInactiveBorderP �� BasedOn - )MaterialDesignTextFieldBoxHoverBackground/  )MaterialDesignThemes.Wpf.ValidationAssist & "MaterialDesignValidationErrorBrush��%�,  &	        �� "  .���  � ��$ Center=���  � �� �� *(TextElement.Foreground)+ �� *FindAncestor+$ 1��" ���  �@ CalendarStyle �� "  .���  � ��# �  ��  � ��# �  ��  �@ CalendarDayButtonStyle �� "  .���  � ��# �  ��  � ��$ 5����  � ��$ 5����  � ��$ 12(���  �@�Cursor$
 Hand����  � ��$ 2q���  � ��$ 28����  � ��$ 28����  � ��$ Center=���  � ��$ Center=���  � �� �� "  .R��    CommonStates��	   $
 0:0:0.1D� Z�  Z�  Z�  Z� .   
Normal��  	MouseOver��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Pressed��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  SelectionStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Unselected��  Selected��. �� .��W� $ 0D�$
 0.75X�$ Opacity�$ SelectedBackground��T� $
 Stop=�$ (TextElement.Foreground)�$ 
NormalText��..�i� $ 0��# �    CalendarButtonFocusStates��	   $
 0D� Z�  Z�  Z�  Z� .   CalendarButtonFocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  Visible=�  CalendarButtonUnfocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  	Collapsed=�  ActiveStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Active��  Inactive��  	DayStates��	   $
 0D� Z�  Z�  Z�  Z� .   
RegularDay��  	Today��. �� .��W� $ 0D�$ 1X�$ Opacity�$ TodayBackground��  BlackoutDayStates��	   $
 0D� Z�  Z�  Z�  Z� .   	NormalDay��  BlackoutDay��. �� .��W� $ 0D�$ 0X�$ Opacity�$ HighlightingBorder��W� $ 0D�$
 0.38X�$ Opacity�$ 
NormalText��.+�A� $ TodayBackground��
������ $ 0Q�#��z��$��1��A� $ SelectedBackground��#���  $ 0Q��� #��z��#��z��#��z���� $ HighlightingBorder��$ 1Q�._�A� $ HighlightBackground��#���  $ 0Q��� $ 
NormalText��#��z��#��z��# z #��z��#��z��$	��5,1q�#��z��A� $ DayButtonFocusVisual��$ 0Q�#���  $��1��$y�	Collapsed=� P�  �@ 
IsInactive  . . ���  � ��$ 0����  � ��$ 0��P�  �@ IsBlackedOut  . . ���  �@�Cursor$ No����  �@ CalendarButtonStyle �� " 	 .���  � ��$ 5����  � ��$ 5����  � ��$ 12(���  �@�Cursor$
 Hand����  � ��
 ���� ��  � ��$ 2q���  � ��$ 48����  � ��$ 48����  � ��$ Center=���  � ��$ Center=���  � �� �� " 	 .R��    CommonStates��	   $
 0:0:0.1D� Z�  Z�  Z�  Z� .   
Normal��  	MouseOver��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Pressed��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Disabled��. �� .��W� $ 0D�$ 0X�$ Opacity�$ HighlightBackground��W� $ 0D�$
 0.35X�$ Opacity�$ 
NormalText��  SelectionStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Unselected��  Selected��. �� .��W� $ 0D�$
 0.75X�$ Opacity�$ SelectedBackground��T� $
 Stop=�$ (TextElement.Foreground)�$ 
NormalText��..�i� $ 0��# �    CalendarButtonFocusStates��	   $
 0D� Z�  Z�  Z�  Z� .   CalendarButtonFocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  Visible=�  CalendarButtonUnfocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  	Collapsed=�  ActiveStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Active��  Inactive��.+�A� $ TodayBackground��#���  $ 0Q�A� $ SelectedBackground��#���  $ 0Q��� #��z��#��z��#��z��A� $ HighlightBackground��#���  $ 0Q��� $ 
NormalText��#��z��#��z��# z #��z��#��z��$	��5,1q�#��z��A� $ DayButtonFocusVisual��$ 0Q�#���  $��1��$y�	Collapsed=� P�  �@	 
IsInactive  . . ���  � ��$ 0����  � ��$ 0����  � �� �� "  .R��� ! �� *)'(materialDesign:ShadowAssist.CacheMode)+ �� *Self+.u��� #" �  $# 
16,8,16,24q�._�
  $$ PART_CalendarItem��#��z��#��z��#% z% #���  ��  �@ IsTodayHighlighted . ��  �@ SelectedDateFormat$ Short=���  � ��# � 	 ��  � ��$ 0,0,0,1q���  � ��$ Stretch=���  � ��$	 0,4q���  �@ TextBoxViewMargin$	 1,0q���  �@=�ErrorTemplate �� ��  �@ UnderlineBrush# �  ��  �@ 
Foreground# �  ��  � �� �� "  & ���� CalendarButtonTemplate
 " ��.R�  
������ #��z��$' Event=�$��Center=�.R�� $( 	PART_Root��.+�  $) PART_TextBox��#��z��$��0��#* z* #+ z+ #, z, #- z- #|�z|�#. z. #/ z/ #0 z0 #1 z1 #2 z2 #3 z3 $��Stretch=�#��z��#4 z4 #5 z5 #6 z6 #7 z7 $��0��#8 z8 #���  #9 z9 #: z: #; z; #< z< #= z= $��Center=�.����`� $> Default=�?   .1��� $@ Padding� �� *TemplatedParent+�� $A PART_Button��$B OneWay=�$@ ActualWidth�.���� $C PART_Button��#��z��|�.  $��Right=�$��25��$��25��$��Center=����� D � ��E   ���� " ��.R�  
������ ���#ABB8D4$' 
EventClock=�$��Center=�$��20��$��20��� $F 
PART_Popup��G . H <.cctor>b__1_0$
��Fade=�$��Custom=�I .  J P�  �@ HasFilledTextField  . . ���  � ��$
 16,8q��� # �   � ����  �@ TextBoxViewMargin$ 0q�P�  �@ HasOutlinedTextField  . . ���  � ��$ 16q��� # �   � ����  �@ TextBoxViewMargin$ 0q�]� K �� L �@ HasFilledTextFieldM .  �� L �@ HasOutlinedTextFieldM .  �� L �@J�IsMouseOverM . ./��� # �   � ��]� K �� L � {�M . �� $N PART_Button��L �@J�IsMouseOverM . ./��� $O PART_Button��# �   � ��P�  � {�  .  . ��� $O PART_Button�� �@J�Opacity$
 0.56Q�]� K �� L � {�M .  �� L �@ HasOutlinedTextFieldM . ./��� $O PART_TextBox��# �   � ��]� K �� $N PART_TextBox��L �@J�IsKeyboardFocusedM . �� L �@ HasOutlinedTextFieldM . ./��� $O PART_TextBox�� �� *1/(materialDesign:TextFieldAssist.UnderlineBrush)+ �� *Self+ � ��P�  �@ IsHeaderVisible  .  . ���  �@ CalendarStyle �� "  .���  �@ IsHeaderVisible .  P �� "  .���  � ��# �  ��  � ��# �  ��  �@ CalendarDayButtonStyle �� "  .���  � ��# �  ��  � ��$ 5����  � ��$ 5����  � ��$ 12(���  �@�Cursor$
 Hand����  � ��$ 2q���  � ��$ 28����  � ��$ 28����  � ��$ Center=���  � ��$ Center=���  � �� �� "  .R��    CommonStates��	   $
 0:0:0.1D� Z�  Z�  Z�  Z� .   
Normal��  	MouseOver��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Pressed��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  SelectionStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Unselected��  Selected��. �� .��W� $ 0D�$
 0.75X�$ Opacity�$ SelectedBackground��T� $
 Stop=�$ (TextElement.Foreground)�$ 
NormalText��..�i� $ 0��# �    CalendarButtonFocusStates��	   $
 0D� Z�  Z�  Z�  Z� .   CalendarButtonFocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  Visible=�  CalendarButtonUnfocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  	Collapsed=�  ActiveStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Active��  Inactive��  	DayStates��	   $
 0D� Z�  Z�  Z�  Z� .   
RegularDay��  	Today��. �� .��W� $ 0D�$ 1X�$ Opacity�$ TodayBackground��  BlackoutDayStates��	   $
 0D� Z�  Z�  Z�  Z� .   	NormalDay��  BlackoutDay��. �� .��W� $ 0D�$ 0X�$ Opacity�$ HighlightingBorder��W� $ 0D�$
 0.38X�$ Opacity�$ 
NormalText��.+�A� $ TodayBackground��
������ $ 0Q�#��z��$��1��A� $ SelectedBackground��#���  $ 0Q��� #��z��#��z��#��z���� $ HighlightingBorder��$ 1Q�._�A� $ HighlightBackground��#���  $ 0Q��� $ 
NormalText��#��z��#��z��# z #��z��#��z��$	��5,1q�#��z��A� $ DayButtonFocusVisual��$ 0Q�#���  $��1��$y�	Collapsed=� P�  �@ 
IsInactive  . . ���  � ��$ 0����  � ��$ 0��P�  �@ IsBlackedOut  . . ���  �@�Cursor$ No����  �@ CalendarButtonStyle �� " 	 .���  � ��$ 5����  � ��$ 5����  � ��$ 12(���  �@�Cursor$
 Hand����  � ��
 ���� ��  � ��$ 2q���  � ��$ 48����  � ��$ 48����  � ��$ Center=���  � ��$ Center=���  � �� �� " 	 .R��    CommonStates��	   $
 0:0:0.1D� Z�  Z�  Z�  Z� .   
Normal��  	MouseOver��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Pressed��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Disabled��. �� .��W� $ 0D�$ 0X�$ Opacity�$ HighlightBackground��W� $ 0D�$
 0.35X�$ Opacity�$ 
NormalText��  SelectionStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Unselected��  Selected��. �� .��W� $ 0D�$
 0.75X�$ Opacity�$ SelectedBackground��T� $
 Stop=�$ (TextElement.Foreground)�$ 
NormalText��..�i� $ 0��# �    CalendarButtonFocusStates��	   $
 0D� Z�  Z�  Z�  Z� .   CalendarButtonFocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  Visible=�  CalendarButtonUnfocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $ 0��  	Collapsed=�  ActiveStates��	   $
 0D� Z�  Z�  Z�  Z� .   
Active��  Inactive��.+�A� $ TodayBackground��#���  $ 0Q�A� $ SelectedBackground��#���  $ 0Q��� #��z��#��z��#��z��A� $ HighlightBackground��#���  $ 0Q��� $ 
NormalText��#��z��#��z��# z #��z��#��z��$	��5,1q�#��z��A� $ DayButtonFocusVisual��$ 0Q�#���  $��1��$y�	Collapsed=� P�  �@	 
IsInactive  . . ���  � ��$ 0����  � ��$ 0����  � �� �� "  .R��� ! �� *)'(materialDesign:ShadowAssist.CacheMode)+ �� *Self+.u��� #" �  $# 
16,8,16,24q�._�
  $$ PART_CalendarItem��#��z��#��z��#% z% #���  ]� K �� L �@J�IsMouseOverM . �� L �@ HasFilledTextFieldM . ./��� # �   � ��P�  �@=�HasError  . . ��� $O PART_TextBox�� �@ HasError . �� # �   � ��.��� ���#E5E5E5Q � RowDefinitionsQ �� $��50 ��� $��80 ��� $��* ��� $��30 �.+�� $��0�����#4D638C.+��� $
��Sale������ *UpdateViewCommand+���� " ��.���  � ��$ 40����  � ��$ 40����  � ��
 ���� ��  � ��$
 Left=���  � ��$ 25 0 0 0q���  � �� �� " ��.R��� #��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver  . . ���  � �� �#283654��  � �� �#283654.���� $��../Images/imageback.png��$��30��$��30����   	txtSearch#��[ 
R � Tag$R 	Izlash...��$	��564��$��34��$��Center=�$��Right=�$��0 0 20 0q��� $��../Images/search.png��$��20��$��20��$��Center=�$��Right=�$��0 0 35 0q�� $��1��S � ColumnDefinitionsS �� $	��254 ��� $	��150 ��� $��* �.+��� $��Kelish vaqti :��$
��16px(�$��25 0 0 0q��� ���#BEBEBE$��1q�$��40��$��	25 10 0 0q�T �� CornerRadius$T 3��
�������._�  $��1��$	��198��$��35�����#A8A0A0$
��Left=�$��	25 10 0 0q�U   SelectedDateU �� *ArrivalDate+$B TwoWay=�
V �� NowW �� TargetNullValue#W ZV �� $��1��$��40��$��90��  txtLogin#��[ $��0 10 0 0q����� *ArrivalTime+$B TwoWay=�.���� -   $C btnClientAdd��$��2������ *AddClientCommand+���� " ��.���  � ��$	 190����  � ��$ 44����  � �� �#4D638C��  � �� �#4D638C��  � ��
 �������  � ��$ Right=���  � ��$ 0 0 25 0q���  � �� �� " ��.R��� $T 5��#��z��#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver  . . ���  � �� �#38739B��  � �� �#38739B.���� $��Mijoz qo'shish��$��Segoe UI)�$
��15px(�� $��2��$��0 5 0 0q�.+��� -   X ��Name$X scrollViewer��$��Disabled=����� " �� �� Y �� BindingY �� *
HasItems+$A dataGrid��Z �� Value	Z False.a���  � ��$
 Auto=�.��&   System.Windows.Controls.DataGrid  -   [  Name$[ dataGridClient��$y�Visible=�$\   HorizontalScrollBarVisibility$
\ Auto=�$
��Auto��]   HorizontalGridLinesBrush] �#E3E2E2^   AutoGenerateColumns^ .  _   GridLinesVisibility$_ 
Horizontal=�`   CanUserAddRows` .  a   CanUserDeleteRowsa .  b   
IsReadOnlyb .  c   CanUserReorderColumnsc .  d   CanUserResizeColumnsd .  e   CanUserResizeRowse .  ���#FFFFFF$��1q�f   SelectionMode$f Single=�g   SelectionUnit$g FullRow=�h �� AlternationCount$h 2��$��	25 0 25 0q����� $@ Clients�$B TwoWay=�i �� SelectedItemi �� $@ Client�$B TwoWay=�    MaterialDesignDataGrid*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader & "MaterialDesignDataGridColumnHeader��%5  '        7  '  D     7  '      '  �    7  '�� �    �� "  8P   .���  �@ GridLinesVisibility$ 
Horizontal=��� "  8P   .���  �@�FocusVisualStyle Z� ��  � �� �#7A7979��  � ��$ 0q���  �@��TextAlignment$
 Left=� P�  �@ 
IsSelected  . . ���  � �� �#B6E0FF�� "   P�  �@ AlternationIndex$  0��. ���  � �� �#FFFFFFP�  �@ AlternationIndex$  1��. ���  � �� �#E3E2E2�� "  8P   .���  � �� �#283654��  � ��
 �������  � ��$ 55����  � ��$ Center=���  � ��$ Center=���  � ��$ 30 0 0 0q���  � �� �� "  .R��� $T 	10 10 0 0��#��z��#��z��._��� $��Center=�$
��Left=�$��15 0 0 0q� �� " ��.���  � �� �#263859j   Columnsj 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumnk   Header$	k Kod��l   
IsReadOnlyl . m   Width5  /System.Windows.Controls.DataGridLengthConverter$m 80 1  +System.Windows.Controls.DataGridBoundColumnn   Bindingn �� *Id+  $k Mijoz��l . $
m 200* n �� *
FullName+  $k Telefon raqami��l . $	m 150 n �� *Phone+  $k Manzili��l . $
m 200* n �� *	Address+  $k Karta raqami��l . $	m 150 n �� *Card+  $k Bonus so'mda��l . $	m 150 n �� *
BonusSum+  $k Bonus dollarda��l . $	m 150 n �� *BonusDollar+4  .System.Windows.Controls.DataGridTemplateColumn  k �� $��Tanlash��$
��100 ��
�������$��Segoe UI)�$��15(�o �� TextAlignment$o Center=�p   CellTemplatep �� .R���   btnPlus#��[ ����  �� " >�$"@ DataContext.TakeOrderCommand�.��  $
' Plus=�
�������$��25��$��25��