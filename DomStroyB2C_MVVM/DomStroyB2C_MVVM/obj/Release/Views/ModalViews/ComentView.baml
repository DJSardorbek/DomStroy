   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews!DomStroyB2C_MVVM.Views.ModalViews  2    ,DomStroyB2C_MVVM.Views.ModalViews.ComentView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews       � Title$  
BasketView��$	��300��$	��400�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=���Z�  � 	Resources  �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation	 �� 
TargetType
 ��Name �� CornerRadius �� Padding ��Name J� IsHitTestVisible
 � Tag �� Padding �� Triggers �� Binding �� RelativeSource �� Value P� Property P� Value��%�  '��       '�� �     '�� �    �� " ��.���  � ��$ Segoe UI)���  � ��$
 20px(���  � ��
 �������  � ��$ Center=���  � ��$ Center=��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��
CaretBrush �#283654��  �@��TextWrapping$
 Wrap=���  � ��$	 120����  � ��$ 40����  � ��$ Bottom=���  � �� �#C0C0C0��  � �� �#8F8F8F��  � ��$ Segoe UI)���  � ��$
 15px(���  � �� �� "	 ��.R�� .+��� $
 Border��$ 5��$ 	20 10 5 5q�$��1q�#��z��#��z��._��� $ PART_ContentHost��$��0q���  .  #��z $ 	50 10 0 5q����� " ��.���  � y�$ 	Collapsed=���  � �� �#A8A0A0��  � ��$ Segoe UI)���  � ��$
 15px(� ��  �� *Text+ �� *TemplatedParent+  .a���  � y�$ Visible=��� " ��.���  � ��$ 40����  � ��$	 130����  � ��$ Segoe UI)���  � ��
 �������  � ��$
 13px(���  � �� �� "	 ��.R��� $ 5��$��1q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@�Tag$
 Save��. ���  � �� �#4D638C��  � �� �#4D638C��  � ��$ Saqlash��P�  �@J�IsMouseOver . . ���  � �� �#4D638C��  � �� �#4D638CP�  �@�Tag$ Cancel��. ���  � �� �#FE8950��  � �� �#FE8950��  � ��$ Bekor qilish��P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q���  � ��$ SemiBold"�.���� ���#283654$ 10��$��1q����#C0C0C0._��  � RowDefinitions �� $��65 ��� $��* �.+�� $��0��.+��� $��Navbatga olish��� $��1�� �� $��* ��� $��80 �.+�� $��0��
�������.+��� -    ��Name$ 
txtComment��$	��324��$	��125��$ Izoh...��.������  �� Path$ Comment� �� UpdateSourceTrigger$ PropertyChanged=�.�� J� InputBindings �� 
 �� Key$ Return�� �� Command �� *SubmitOrderCommand+.���� $ 	0 0 10 10��$��1��
�������._��  � ColumnDefinitions �� �� .+��� -    ��Name$ 	btnSubmit��$��0��$
 Save������ *SubmitOrderCommand+�� -   $ 	btnCancel��$��1��$ Cancel��