   M S B A M L   `   `   `  ����D  @WpfApp8_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfApp8_1	WpfApp8_1  5   	       WpfApp8_1.GeneralWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfApp8_1     5   	   -   5          � Title$!  Личный кабинет��5   	   $	��450��6    $	��800��6-    � 
ResizeMode$ NoResize=�69   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF3B3B3B��6    � Offset$ 1Q�61   � 5      $ 	#FFBEBEBE��6   $ 0Q�61   5      .+�5   
   o� $��40��6   $	��Top=�6   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF3B3B3B��6#   $ 1Q�65   � 5      $ 	#FFBEBEBE��6#   $ 0.531Q�65   � 5      $ 	#FF6C6C6C��6#   $ 0Q�65   5      .@�5      m� -   5         m�Name$ 	MenuLeave��5      $1��+Выйти из учетной записи��6*   $
��Bold"�6b   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ 	#FF757575��6'   $ 1Q�69   � 5      $ 	#FFBEBEBE��6'   $ 0.531Q�69   � 5      $ 	#FF6C6C6C��6'   $ 0Q�69   5      5       m� 5!      -   5        $ MenuCreateOrder��5!      $��Создать заказ��60   $
��Bold"�6G   ��5"      �� 5#      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5$      � $ 	#FF757575��6'   $ 1Q�69   � 5%      $ 	#FFBEBEBE��6'   $ 0.531Q�69   � 5&      $ 	#FF6C6C6C��6'   $ 0Q�69   5'      5)      m� 5*      -   5        $ MenuSewOrder��5*      $#��Смотреть заказы��6-   $
��Bold"�6F   ��5+      �� 5,      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5-      � $ 	#FF757575��6'   $ 1Q�69   � 5.      $ 	#FFBEBEBE��6'   $ 0.531Q�69   � 5/      $ 	#FF6C6C6C��6'   $ 0Q�69   50      52      m� 53      -   5        $ MenuAdministration��53      $(��"Администрирование��63   $
��Bold"�6N   ��54      �� 55      $ 0.5,1&�6*   $ 0.5,0&�6;   .��56      � $ 	#FF757575��6'   $ 1Q�69   � 57      $ 	#FFBEBEBE��6'   $ 0.531Q�69   � 58      $ 	#FF6C6C6C��6'   $ 0Q�69   59      .@�5;      �� $!��Учетные записи��6   5<      m� 5=      -   5        $ MenuAboutProgram��5=      $*��$Справка о программе��61   $��40��6N   $
��Bold"�6Z   ��5>      �� 5?      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5@      � $ 	#FF757575��6'   $ 1Q�69   � 5A      $ 	#FFBEBEBE��6'   $ 0.531Q�69   � 5B      $ 	#FF6C6C6C��6'   $ 0Q�69   5C      5E      5F      �� 5G   
   $��Логин:��6   $
��Left=�6!   $��44��6<   $��	50,59,0,0q�6H   $	��Top=�6[   $	��200��6s   $��Cascadia Code)�6   $��24(�6�   �� 5H   
   $
��Left=�6   $��40��6/   $��
50,103,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��200��6{   $��Cascadia Code)�6�   $��36(�6�   ��5I      �� 5J      $ 0.5,1&�6&   $ 0.5,0&�67   .��5K      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5L      $ 	#FFDEDEDE��6#   $ 1Q�65   5M      5O      �� 5P   
   $��Имя:��6   $
��Left=�6   $��44��6:   $��
50,145,0,0q�6F   $	��Top=�6Z   $	��200��6r   $��Cascadia Code)�6~   $��24(�6�   �� 5Q   
   $
��Left=�6   $��40��6/   $��
50,189,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��200��6{   $��Cascadia Code)�6�   $��36(�6�   ��5R      �� 5S      $ 0.5,1&�6&   $ 0.5,0&�67   .��5T      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5U      $ 	#FFDEDEDE��6#   $ 1Q�65   5V      5X      �� 5Y   
   $��Фамилия:��6   $
��Left=�6#   $��44��6>   $��255,145,0,0q�6J   $	��Top=�6_   $	��200��6w   $��Cascadia Code)�6�   $��24(�6�   �� 5Z   
   $
��Left=�6   $��40��6/   $��255,189,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��200��6|   $��Cascadia Code)�6�   $��36(�6�   ��5[      �� 5\      $ 0.5,1&�6&   $ 0.5,0&�67   .��5]      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5^      $ 	#FFDEDEDE��6#   $ 1Q�65   5_      5a      �� 5b   
   $��Очество:��6   $
��Left=�6#   $��44��6>   $��460,145,0,0q�6J   $	��Top=�6_   $	��200��6w   $��Cascadia Code)�6�   $��24(�6�   �� 5c   
   $
��Left=�6   $��40��6/   $��460,189,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��200��6|   $��Cascadia Code)�6�   $��36(�6�   ��5d      �� 5e      $ 0.5,1&�6&   $ 0.5,0&�67   .��5f      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5g      $ 	#FFDEDEDE��6#   $ 1Q�65   5h      5j      �� 5k   
   $��	Роль:��6   $
��Left=�6    $��44��6;   $��
50,231,0,0q�6G   $	��Top=�6[   $	��200��6s   $��Cascadia Code)�6   $��24(�6�   �� 5l   
   $
��Left=�6   $��40��6/   $��
50,275,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��200��6{   $��Cascadia Code)�6�   $��36(�6�   ��5m      �� 5n      $ 0.5,1&�6&   $ 0.5,0&�67   .��5o      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5p      $ 	#FFDEDEDE��6#   $ 1Q�65   5q      5s      �� 5t   
   $��Почта:��6   $
��Left=�6!   $��44��6<   $��255,231,0,0q�6H   $	��Top=�6]   $	��200��6u   $��Cascadia Code)�6�   $��24(�6�   �� 5u   
   $
��Left=�6   $��40��6/   $��255,275,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��200��6|   $��Cascadia Code)�6�   $��36(�6�   ��5v      �� 5w      $ 0.5,1&�6&   $ 0.5,0&�67   .��5x      � $ 	#FFBBBBBB��6#   $ 0Q�65   � 5y      $ 	#FFDEDEDE��6#   $ 1Q�65   5z      5|      5}      5~      