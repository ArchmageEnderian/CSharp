   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  MainForm��5   	   $��569.388��6   $��1072.066��6+   ��5
      �� 5   
    �� ImageSource$ Fon2.png��6   6.   .��5      � .+�5   
   �� .+�5      �� -   5         ��Name$ BlueBox��5      $3��-Проверять совместимость��6(    � ToolTip$M GДля проверки на совместимость жми сюда��6k   $
��Left=�6�   $��19��6�   $��
681,42,0,0q�6�   $	��Top=�6�   $	��172��6�   6�   � 5      -   5         �Name$ popup1��5       � 	StaysOpen .  $��Mouse=�66   $	��180��6H    � AllowsTransparency . .��5      �� $
��Wrap=�6   $	��180��60   
������� J� Opacity$	 0.8Q�6S   DBСпасибо metanit.com, ты спасаешь мой день!5      5      9� 5      $��А вы знали?��6   $
��Left=�6,   $	��171��6G   $��	681,0,0,0q�6T   $	��172��6g   .��5      �� .+�5      � 
�������6   �� 5      $	��148��6    
��������� 6A   $,�&Символ @ (эт) называют��6E   �� 6e   �� 6q   $6�0 'собакой' только в странах��6u   �� 6�   �� 6�   $6�0 бывшего Советского Союза,��6�   �� 6�   �� 6�   $:�4 в большинстве других языков��6�   �� 6  �� 6  $.�( этот символ называют ��6  �� 64  �� 6@  $5�/'улиткой' или 'обезьянкой'.��6D  6j  5      5      �� 5      -   5        $��Фейерверк��5      $
��Left=�6)   $��55��6D   $��	968,0,0,0q�6P   $��67��6c   6n   5      o� 5   
   $
��Left=�6   $��31��6*   $	��Top=�66   $
��1064��6N   .@�5      m� -   5        $��Конфигурация��5      $��31��6-   $	��100��69    J� InputBindings 5      �� 5       
	 �� Key$	 S��6!   
 �� 	Modifiers$
 controlf�6)   .@�5"      �� -   5         ��Name$ SaveBut��5"      $)��#Сохранить сборку (S)��6*   6I   5$      m� 5&      -   5        $!��О разработчике��5&      $��31��6/   $	��100��6;   6G   5*      �� 5,   
   -   5         ��Name$ 	ProcLabel��5,      $��Процессор��6$   $
��Left=�68   $��40��6S   $��	10,36,0,0q�6_   $	��Top=�6r   
���"�"�$	��122��6�   $��24(�6�   $��Times New Roman)�6�   �� 5-   
   -	   5        $ MatLabel��5-      $'��!Материнская плата��6$   $
��Left=�6@   $��40��6[   $��
10,113,0,0q�6g   $	��Top=�6{   
���"�"�$	��209��6�   $��24(�6�   $��Times New Roman)�6�   �� 5.   
   -
   5        $ 
VideoLabel��5.      $��Видеокарта��6$   $
��Left=�69   $��40��6T   $��
10,189,0,0q�6`   $	��Top=�6t   
���"�"�$	��133��6�   $��24(�6�   $��Times New Roman)�6�   �� 5/   
   -   5        $ 	OperLabel��5/      $)��#Оперативная память��6$   $
��Left=�6A   $��40��6\   $��
10,266,0,0q�6h   $	��Top=�6|   
���"�"�$	��219��6�   $��24(�6�   $��Times New Roman)�6�   �� 50   
   -   5        $ 	HranLabel��50      $%��Хранилище данных��6$   $
��Left=�6?   $��40��6Z   $��
10,343,0,0q�6f   $	��Top=�6z   
���"�"�$	��219��6�   $��24(�6�   $��Times New Roman)�6�   �� 51   
   -   5        $ 
BlockLabel��51      $��Блок питания��6$   $
��Left=�6;   $��40��6V   $��
10,419,0,0q�6b   $	��Top=�6v   
���"�"�$	��149��6�   $��24(�6�   $��Times New Roman)�6�   �� 53   
   $��Right=�6   $	��332��63   $��0,36,388,10q�6?   .��54      �� .+�55      �� -   5         ��Name$ combo1��55      $
��Left=�6=   $	��100��6X   $	��Top=�6e   $	��315��6}   6�   �� 56      -   5        $ combo2��56      $
��Left=�6<   $	��100��6W   $	��Top=�6e   $	��315��6}   6�   �� 57      -   5        $ combo3��57      $
��Left=�6>   $	��100��6Y   $	��Top=�6g   $	��315��6   6�   �� 58      -   5        $ combo4��58      $
��Left=�6=   $	��100��6X   $	��Top=�6f   $	��315��6~   6�   �� 59      -   5        $ combo5��59      $
��Left=�6=   $	��100��6X   $	��Top=�6f   $	��315��6~   6�   �� 5:      -   5        $ combo6��5:      $
��Left=�6>   $	��100��6Y   $	��Top=�6g   $	��315��6   6�   5;      5<      5?      5@      