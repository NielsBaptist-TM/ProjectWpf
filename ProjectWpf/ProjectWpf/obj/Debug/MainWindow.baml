   M S B A M L   `   `   `  ����E  AProjectWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectWpf
ProjectWpf  5   	       ProjectWpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectWpf     5   	     � Title$  
MainWindow��5   	   $
��1080��6   $
��1920��6*    � WindowStartupLocation$ CenterScreen=�67    � WindowState$ 	Maximized=�6\   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��960* �6   6.    � RowDefinitions 5   
   �� 5      $��1* �6   6*    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � �� �#2071786A   �� 5       � �� �#F5E9BE6A   �� 5       � ��$ 40(�6-   6:   �� 5       � ��$
 Bold"�6/   6>   5      5      	 J� Effect	 5   
   -  'System.Windows.Media.Effects.BlurEffect  5      
   Radius$
 0Q�6   ��5   
   �� 5       �� ImageSource$ background.jpg��6   .+�5   
   �� -   5         ��Name$ 
BtnNewGame��5      $��0��6%   $��307,656,1290,208q�6K   
�������
���   �	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       .��5!      
Nieuw spel6*   �� 5"   
   -   5        $ BtnHighscores��5"      $��810,658,783,208q�6D    J� RenderTransformOrigin$ 0.5,0.5&�6]   
���   �
�������	 5#        5$      z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*       �� Angle$
 -0.1Q�6&   T� 5+      5,      .��5-   &   
Highscores5.      �� 5/   
   $��Trivial pursuit: The game��6   $	��125(�64   $��139,205,172,632q�6C   $��Verdana)�6\   $ 
0.506,1.29&�6q   
�������6�   �� 50   
   -   5        $ BtnQuestions��50      $��1288,660,311,214q�6'   $ 0.5,0.5&�6A   
���   �
�������$��Vragen��6�   	 51        52      z�54      V� 55      .~�56      �� �� 57      �� 58      $
 -0.1Q�6&   T� 59      5:      5<      5=      5>      