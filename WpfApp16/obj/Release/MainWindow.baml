   M S B A M L   `   `   `  ���� C  ?WpfApp16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp16WpfApp16      WpfApp16.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:WpfApp16       � Title$  	TestTable��$	��450��$	��800�� � 	Resources    HeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value �� 
TargetType �� TextAlignment��%�   &	        �� "  .���  � ��$ Center=���  � ��
 �������  � �� �� "  .R��� $��1q�
���   �#��z��._��� $ Center=�$��Center=�$��Center=�
�������$��SemiBold"����� .��� .+�&   System.Windows.Controls.DataGrid  -     Name$ MainDG��$��10,50,10,10q�   AutoGenerateColumns .  $��1q�
���   �	   CanUserAddRows	 .   )  #System.Windows.Controls.DataGridRow
 �� Color �� Opacity �� 	Resources �� Triggers P� Property P� Value��%^  '        �� "  .���  � ��
 �������  � �� �� $
 Black��$	 0.8Q� ���� $
 Transparent��(��       *1/SystemColors.InactiveSelectionHighlightBrushKey+)�� $
 	#FF4A5939��$	 0.8Q�(��       * SystemColors.HighlightBrushKey+) P�  �@J�IsMouseOver . . ���  � �� �� $
 	#FF3E3E42��$	 0.8Q�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.1*    HeaderStyle# [     CellTemplate �� .R��� ���� *ID+  $ Фамилия��$ 1* # [   �� .R��� ���� *	Surname+  $ Имя��$ 1* # [   �� .R��� ���� *Name+  $ Отчество��$ 1* # [   �� .R��� ���� *
Patronomic+  $ Дата рождения��$ 1* # [   �� .R��� ���� *
Birthday+  $! Место рождения��$ 1* # [   �� .R��� ���� *Place+  $! Номер телефона��$ 1* # [   �� .R��� ���� *Number+  $ Возраст��$
 0.5* # [   �� .R��� ���� *Age+�� -    ��Name$	 Btn��$��40��$	��150��$��Настройки��$��Right=�$	��Top=�$��0,5,10,0q��� -   $
 Btn2��$��40��$	��150��$��Обновить��$��Right=�$	��Top=�$��	0,5,170,0q�