   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews!DomStroyB2C_MVVM.Views.ModalViews  :    4DomStroyB2C_MVVM.Views.ModalViews.CreateMovementView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com    � Title$  
BasketView��$	��358��$	��400�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=���Z�  � 	Resources  �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation	 �� 
TargetType
 ��Name �� CornerRadius �� Padding ��Name J� IsHitTestVisible
 � Tag �� Padding �� Triggers �� Binding �� RelativeSource �� Value P� Property P� Value��%k  '��       '�� �     '�� �    �� " ��.���  � ��$ Segoe UI)���  � ��$
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
 Save��. ���  � �� �#4D638C��  � �� �#4D638C��  � ��$ Qo'shish��P�  �@J�IsMouseOver . . ���  � �� �#4D638C��  � �� �#4D638CP�  �@�Tag$ Cancel��. ���  � �� �#FE8950��  � �� �#FE8950��  � ��$ Bekor qilish��P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q���  � ��$ SemiBold"�.���� ���#283654$ 10��$��1q����#C0C0C0._��  � RowDefinitions �� $��65 ��� $��* �.+�� $��0��.+��� $��Tovar ko'chirish yaratish��� $��1�� �� $��71 ��� $��64 ��� $��64 ��� .+�� $��0��
�������.+��� -    ��Name$ txtName��$	��324��$��45��.������  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�.����  �� Orientation$ 
Horizontal=�$��-260,-22,0,0q�$��Center=�$��Center=�$��45��
�������.+��� $
��Nomi��$��Segoe UI)�$
��10px(����#A7A7A7 �� TextAlignment$ Center=�$��5 0 0 0q��� $��*��$��Segoe UI)�$
��18px(�
���  ��$��15��$��Center=�$��Center=�$ Center=�
�������$��0 5 0 0q�� $��1��
�������.+��� $	��324��$��45�� �� 
IsReadOnly . .������ $ 
FromBranch�$ PropertyChanged=�.���� $ 
Horizontal=�$��-240,-28,0,0q�$��Center=�$��Center=�$��60��
�������.+��� $��	Filialdan��$��Segoe UI)�$
��10px(����#A7A7A7$ Center=�$��5 0 0 0q��� $��*��$��Segoe UI)�$
��18px(�
���  ��$��15��$��Center=�$��Center=�$ Center=�
�������$��0 5 0 0q�� $��2��
�������.+���    ComboBoxTest2#��[  $	��324��$��45���� $ 
Horizontal=�$��-250,-48,0,0q�$��Center=�$��Center=�$��50��$��15��
�������.+��� $��Filialga��$��Segoe UI)�$
��10px(����#A7A7A7$ Center=�$��5 0 0 0q��� $��*��$��Segoe UI)�$
��18px(�
���  ��$��15��$��Center=�$��Center=�$ Center=�
�������$��0 5 0 0q��� $ 	0 0 10 10��$��3��
�������._��  � ColumnDefinitions �� �� .+��� -    ��Name$ 	btnSubmit��$��0��$
 Save������ *PostClientCommand+�� -   $ 	btnCancel��$��1��$ Cancel��� $��1��$��80��$��80��$��	0 -50 0 0q�y��� *LoadingVisibility+��!�   !� Visual  �� "  WpfAnimatedGif.ImageBehavior!   AnimatedSource$ ! /Views/Loading/loading.gif��"   	AutoStart" . #   RepeatBehavior$# 1��