   M S B A M L   `   `   `  ����D  @WpfApp8_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfApp8_1	WpfApp8_1  5   	       WpfApp8_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfApp8_1     5   	     � Title$  Вход��5   	   $	��450��6   $	��300��6#    � 
ResizeMode$ NoResize=�6E   ��6/   Z� .��5	      � $��0,0,0,-6q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF3B3B3B��6    � Offset$ 1Q�61   � 5      $ 	#FFBEBEBE��6   $ 0Q�61   5      .+�5   
   �� -   5         ��Name$ AcceptButton��5      $��
Войти��6'   $��Center=�67   $��70��6T   $��	0,197,0,0q�6`   $	��Top=�6s   $	��200��6�   $��Cascadia Code)�6�   $��36(�6�   
���   �
���   ���5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFBEBEBE��6#   $ 0Q�65   � 5      $ 	#FF7C7C7C��6#   $ 1Q�65   5      5      �� 5   
   $��Пароль:��6   $��Center=�6"   $��44��6?   $��	0,108,0,0q�6K   $	��Top=�6^   $	��200��6v   $��Cascadia Code)�6�   $��24(�6�   �� 5   
   $��Логин:��6   $��Center=�6!   $��44��6>   $��0,19,0,0q�6J   $	��Top=�6\   $	��200��6t   $��Cascadia Code)�6�   $��24(�6�   G� 5   
   -   5         G�Name$ PasswordBox��5      $��Center=�6+   $��40��6H   $��	0,152,0,0q�6T   $	��Top=�6g   $	��200��6   $��Cascadia Code)�6�   $��36(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5      $ 	#FFDEDEDE��6#   $ 1Q�65   5      5!      �� 5"   
   -   5         ��Name$ LoginBox��5"      $��Center=�6$   $��45��6A   $��0,63,0,0q�6M   	 �� TextWrapping$
	 Wrap=�6_   $	��Top=�6s   $	��200��6�   $��Cascadia Code)�6�   $��36(�6�   .��6�   ��5#      �� 5$      $ 0.5,1&�6&   $ 0.5,0&�67   .��5%      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5&      $ 	#FFDEDEDE��6#   $ 1Q�65   5'      .��5(   "   5)      �� 5*   
   $>��8!На вход отводится одна минута!��6   $��24��6:   $��	0,366,0,0q�6F   $	��Top=�6Y   $��Cascadia Code)�6q   $��24(�6�   $��14(�6�   $��Center=�6�   ���	#FFFF41416�   �� 5+   
   $��Время:��6   $��Center=�6!   $��44��6>   $��	0,272,0,0q�6J   $	��Top=�6]   $	��200��6u   $��Cascadia Code)�6�   $��24(�6�   �� 5,   
   -   5        $ TimerBox��5,      $��45��6$   $
	 Wrap=�60   $	��Top=�6D   $��Cascadia Code)�6\   $��36(�6w   $��	0,316,0,0q�6�   
 �� 
IsReadOnly
 . $��Center=�6�   $	��200��6�   .��6�   ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 50      $ 	#FFDEDEDE��6#   $ 1Q�65   51      .��52   "   53      55      56      