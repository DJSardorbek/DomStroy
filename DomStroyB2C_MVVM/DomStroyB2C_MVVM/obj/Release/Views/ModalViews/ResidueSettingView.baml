   M S B A M L   `   `   `  ���� K  GDomStroyB2C_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews!DomStroyB2C_MVVM.Views.ModalViews  :    4DomStroyB2C_MVVM.Views.ModalViews.ResidueSettingView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:DomStroyB2C_MVVM.Views.ModalViews     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com    � Title$  
BasketView��$	��730��$	��400�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=���Z�  � 	Resources  �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation	 �� 
TargetType
 ��Name �� CornerRadius �� Padding ��Name J� IsHitTestVisible
 � Tag �� Padding �� Triggers �� Binding �� RelativeSource �� Value P� Property P� Value��%l  '��       '�� �     '�� �    �� " ��.���  � ��$ Segoe UI)���  � ��$
 20px(���  � ��
 �������  � ��$ Center=���  � ��$ Center=��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��
CaretBrush �#283654��  � ��$	 120����  � ��$ 28����  � ��$ Center=���  � �� �#C0C0C0��  � �� �#8F8F8F��  � ��$ Segoe UI)���  � ��$
 12px(���  � �� �� "	 ��.R�� .+��� $
 Border��$ 5��$ 20 4 5 5q�$��1q�#��z��#��z��._��� $ PART_ContentHost��$��0q���  .  #��z $ 
100 10 0 5q����� " ��.���  � y�$ 	Collapsed=���  � �� �#A8A0A0��  � ��$ Segoe UI)���  � ��$
 15px(� ��  �� *Text+ �� *TemplatedParent+  .a���  � y�$ Visible=��� " ��.���  � ��$ 40����  � ��$	 130����  � ��$ Segoe UI)���  � ��
 �������  � ��$
 13px(���  � �� �� "	 ��.R��� $ 5��$��1q�#��z��#��z��._��� $��Center=�$��Center=� P�  �@�Tag$
 Save��. ���  � �� �#4D638C��  � �� �#4D638C��  � ��$ 
Tasdiqlash��P�  �@J�IsMouseOver . . ���  � �� �#4D638C��  � �� �#4D638CP�  �@�Tag$ Cancel��. ���  � �� �#FE8950��  � �� �#FE8950��  � ��$ Bekor qilish��P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q���  � ��$ SemiBold"�.���� ���#283654$ 10��$��1q����#C0C0C0._��  � RowDefinitions �� $��65 ��� $��* �.+�� $��0��.+��� ���� *ProductName+� $��1�� �� $��40 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��47 ��� $��60 ��� .+�� $��0��
������� � ColumnDefinitions �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Oy��
���   ��� $��1��$��Miqdori��
���   �� $��1��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Yanvar��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=� �� TextAlignment$ Center=�
��������� $��1��$	��210��$��28������  �� Path$ January� �� Mode$ TwoWay=�� $��2��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Fevral��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ February�$ TwoWay=�� $��3��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$
��Mart��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ March�$ TwoWay=�� $��4��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Aprel��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ April�$ TwoWay=�� $��5��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$	��May��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $	 May�$ TwoWay=�� $��6��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$
��Iyun��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $
 June�$ TwoWay=�� $��7��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$
��Iyul��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $
 July�$ TwoWay=�� $��8��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Avgust��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ August�$ TwoWay=�� $��9��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Sentabr��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ 	September�$ TwoWay=�� $��10��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Oktabr��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ October�$ TwoWay=�� $��11��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Noyabr��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ November�$ TwoWay=�� $��12��
������� �� $
��0.8* ��� $
��1.8* �.+��� $��0��$��Dekabr��$��Segoe UI)�$
��13px(����#A7A7A7$��90��$��Center=�$��Center=�$ Center=�
��������� $��1��$	��210��$��28������ $ December�$ TwoWay=��� $ 	0 0 10 10��$��13��
�������._��  �� �� .+��� -    ��Name$ 	btnSubmit��$��0��$
 Save������ *SubmitMinimalCommand+�� -   $ 	btnCancel��$��1��$ Cancel��� $��1��$	��150��$	��150��$��	0 -50 0 0q�y��� *LoadingVisibility+��!�  !� Visual �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$  /Views/Loading/loading.gif��   	AutoStart .     RepeatBehavior$  1��