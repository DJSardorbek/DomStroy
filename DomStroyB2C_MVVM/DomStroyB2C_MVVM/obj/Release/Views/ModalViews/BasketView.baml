   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  K GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews!DomStroyB2C_MVVM.Views.ModalViews 2   ,DomStroyB2C_MVVM.Views.ModalViews.BasketView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews       � Title$  
BasketView��$	��600��$	��400�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=���Z�  � 	Resources  �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation	 �� 
TargetType
 ��Name �� CornerRadius �� Padding ��Name J� IsHitTestVisible
 � Tag �� Padding �� Triggers �� Binding �� RelativeSource �� Value P� Property P� Value��%j  '��       '�� �     '�� �    �� " ��.���  � ��$ Segoe UI)���  � ��$
 20px(���  � ��
 �������  � ��$ Center=���  � ��$ Center=��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��
CaretBrush �#283654��  � ��$	 120����  � ��$ 40����  � ��$ Bottom=���  � �� �#C0C0C0��  � �� �#8F8F8F��  � ��$ Segoe UI)���  � ��$
 15px(���  � �� �� "	 ��.R�� .+��� $
 Border��$ 5��$ 	20 10 5 5q�$��1q�#��z��#��z��._��� $ PART_ContentHost��$��0q���  .  #��z $ 
100 10 0 5q����� " ��.���  � y�$ 	Collapsed=���  � �� �#A8A0A0��  � ��$ Segoe UI)���  � ��$
 15px(� ��  �� *Text+ �� *TemplatedParent+  .a���  � y�$ Visible=��� " ��.���  � ��$ 40����  � ��$	 130����  � ��$ Segoe UI)���  � ��
 �������  � ��$
 13px(���  � �� �� "	 ��.R��� $ 5��$��1q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@�Tag$
 Save��. ���  � �� �#4D638C��  � �� �#4D638C��  � ��$ Saqlash��P�  �@J�IsMouseOver . . ���  � �� �#4D638C��  � �� �#4D638CP�  �@�Tag$ Cancel��. ���  � �� �#FE8950��  � �� �#FE8950��  � ��$ Bekor qilish��P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q���  � ��$ SemiBold"�.���� ���#283654$ 10��$��1q����#C0C0C0._��  � RowDefinitions �� $��65 ��� $��* �.+�� $��0��.+��� $��Korzinka��� $��1�� �� $��71 ��� $��64 ��� $��64 ��� $��64 ��� $��64 ��� $��64 ��� $��64 ��� .+�� $��0��
�������.+��� $	��324��$��45�� �� 
IsReadOnly . ����  �� Path$ Product.Name��� $��Mahsulot��$��Segoe UI)�$
��10px(����#A7A7A7$��50��$��Center=�$��Center=� �� TextAlignment$ Center=�$��-250,-22,0,0q�
�������� $��1��
�������.+��� $	��324��$��45�� . ���� $ Product.Producer��� $��Ishlab chiqaruvchi��$��Segoe UI)�$
��10px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�$��-210,-28,0,0q�
�������� $��2��
�������.+��� $	��324��$��45�� . ���� *Product.Measurement+�� $��O'lchov birligi��$��Segoe UI)�$
��10px(����#A7A7A7$��70��$��Center=�$��Center=�$ Center=�$��-230,-28,0,0q�
�������� $��3��
�������.+��� $	��324��$��45�� . ���� *Product.Amount+�� $��Mavjud miqdor��$��Segoe UI)�$
��10px(����#A7A7A7$��80��$��Center=�$��Center=�$ Center=�$��-220,-28,0,0q�
�������� $��4��
�������.+��� $	��324��$��45�� . ���� *Product.Currency+�� $��Valyuta��$��Segoe UI)�$
��10px(����#A7A7A7$��40��$��Center=�$��Center=�$ Center=�$��-260,-28,0,0q�
�������� $��5��
�������.+��� $	��324��$��45�� . ���� *Product.Selling_price+�� $��Narxi��$��Segoe UI)�$
��10px(����#A7A7A7$��40��$��Center=�$��Center=�$ Center=�$��-260,-28,0,0q�
�������� $��6��
�������.+��� -    ��Name$ 	txtAmount��$ Miqdorni kiriting...��$	��324��$��45��$��0��.������ $ Enter_amount� �� UpdateSourceTrigger$ PropertyChanged=�.��.���� $��*��$��Segoe UI)�$
��18px(�
���  ��$��15��$��Center=�$��Center=�$ Center=�$��-285,-20,0,0q�
��������� $ 	0 0 10 10��$��7��
�������._��  � ColumnDefinitions �� �� .+��� -    ��Name$ 	btnSubmit��$��0��$
 Save������ *SubmitCommand+�� -   $ 	btnCancel��$��1��$ Cancel��