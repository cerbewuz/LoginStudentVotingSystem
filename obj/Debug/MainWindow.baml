   M S B A M L   `   `   `  ����S  OLoginStudentVotingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LoginStudentVotingSystemLoginStudentVotingSystem  5   	   )    #LoginStudentVotingSystem.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LoginStudentVotingSystem     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5        $ ��/images/exit-lightmode.png��5      $��1��64    K� ZIndex$ 1��6D      
imageClose#��[  6n   �� 5   
    �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 #3AA9AD��6#   
 � Offset$
 0Q�63   � 5      $	 #3AADA1��6#   $
 1Q�63   5      ._�5      � .+�5      �� .+�5      �  � Points �    -1��� ;X�����#4EB1B66:   A� 5      $��40��6   $��40��6)   ���#4EB1b6 �� Left$	 249��6D   
 �� Top$	 390��6V   A� 5      $��
50 400 0 0q�6   $��20��62   $��20��6=   ���#4EB1b66I   5      �� 5      $��Center=�6   .+�5       �� $��Sign Up��6      	titleText#��[ 6/   �� 5!      $,��&Create a new account to connect to us.��6      
normalText#��[ 6N    J� Opacity$	 0.8Q�5"      $��20 30 q�6,   �� 5#      -   5        $��Sign Up��5#       
 button#��[ 6E   $	��218��6e   5$      5%      5&      �� 5(   
   -   5        ���#ffffff$��1��5(   &   $ 	0 10 10 0��66   ._�5)      �� $��Center=�6   .+�5*      �� $��Sign In��6   #��[ 6+   ���#3ab19b$��	0 20 0 15q�6c   �� 5+      $��1q�6   $
��70 7q�6-   $ 5��6;   ._�5,      � $
��7 30q�6   5.      5/      �� 51      $��1q�6   ���#acb0af$
��70 7q�6C   $ 5��6Q   ._�52      � $	��7 9q�6    53      �� 54      $
��auto �6/   �� 55      $��* �6/   .+�57      �� $��/images/id-lightmode.png��6    $��20��6B   $��20��6N   �� 58      -   5         ��Name$ textStudentId��58   $   $��Enter your ID��6_     textHint#��[ 59   "   �� 5:      -   5         ��Name$ txtStudentId��5:   "     textBox#��[ 6_   5<      5=      �� 5?      $��1q�6   ���#acb0af$
��70 7q�6C   $ 5��6Q   ._�5@      � $	��7 9q�6    5A      �� 5B      $
��auto �6/   �� 5C      $��* �6/   .+�5E      �� $��/images/pw-lightmode.png��6    $��20��6B   $��20��6N   �� 5F      -   5        $ textPassword��5F   $   $��Password��6]   #��[ 5G      $��1��6?   $��Right=�6O   $	��294��6k   G� 5H      -   5         G�Name$ txtPassword��5H   &   $��20��6i   #��[ 6u   5I      5J      �� 5L      -   5        $��Sign Up��5L        signinbutton#��[ 6@   5N      5O      5Q      5R      