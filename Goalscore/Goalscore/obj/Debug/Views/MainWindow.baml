   M S B A M L   `   `   `  ����D  @Goalscore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Goalscore	Goalscore  5   	       Goalscore.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Goalscore     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6/   -   5          �Name$
  Home��5   	    � Title$ 
MainWindow��5	   	   $	��720��5
   	   $
��1280��5   	    � Icon$ ../icon_main.ico��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      �� -   5         ��Name$ WindowBorder��5   	   	 �� CornerRadius$	 20��5         SecundaryBackgroundColor#���   5   	   ._�5   
   � 
 � RowDefinitions
 5      �� 5      $��44 �6    �� 5      .+�5      � $��0��6   .+�5      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�    �� Orientation$ 
Horizontal=�6�   $��RightToLeft=�6�   .+�5      �� -   5         ��Name$ btnClose��5        IconButtonsStyle#��[ 6/    	 close#���  6Y   
 � Tag$ IsCloseButton��6�   ��6{   �� *CloseWindowCommand+6�   �� 5       -   5        $ 
btnRestore��5       $	��5 0q�61   ��6>   �� *RestoreWindowCommand+��5!      �� 5"       �� 
TargetType" ��6$    �� BasedOn# [ 6A   .�5#   "   ��  �� Property � ��  maximize �� Value# �  6<    �� Triggers 5$   "   �� 5%   &    �� Binding 62   ��  �� ElementName$
 Home�� �� Path$ WindowState� �� Value 	Maximized6i   .a�5&   *   ��  � ��  restore# �  6D   5'   '   5)      5+      �� 5,      -   5        $ btnMinimize��5,      #���  62     minimize#���  6]   ��6�   �� *MinimizeWindowCommand+5-      5/      � 50      $��1��6    � ColumnDefinitions 51      �� 52      $	��250 �6'   �� 53      .+�57      � $��0��6   .+�58      �� $	 0 0 0 10��6    �� Padding$ 10q�59      #���   5:      ._�5;      � -   5         �Name$ gridMenu��5;      
 5<      �� 5=   "   $��60 �60   �� 5>   "   $��* �60   �� 5?   "   $	��100 �60   �� 5@   "   $��80 �60   .+�5D      �� $��0��6)   $ 
Horizontal=�66   .+�5E   "   �� $!��/Resources/Icons/Logo_2.png��6(   $
��Fill=�6M   $��36��6\   $��36��6h   $��Center=�6s   $��10 0 0 0q�6�   �� 5F   "   $��	GoalScore��6(     SecundaryBlueColor#���  6<   $
��Bold"�6n   $��24(�6�   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��5 0 0 0q�6�   5G      �� 5I      $��1��6)   .+�5J   "   	� -   5         	�Name$ rdHome��5J   .   $
��Home��6>     MenuRadioButtonStyle#���  6M     home# �  6|   $��0 30 0 0q�6�   ��6�   �� *HomePageCommand+	� 5K   "   -   5        $ 	rdPlayers��5K   .   $��
My Players��6A   #���  6V    	 collections# � 	 6�   $��0 1 0 1q�6�   ��6�   �� *MyPlayersPageCommand+	� 5L   "   -	   5        $ 
rdUserTeam��5L   .   $��My Team��6B   #���  6T    
 information# � 
 6�   $��0 1 0 1q�6�   ��6�   �� *UserTeamPageCommand+	� 5M   "   -
   5        $ 	rdProfile��5M   .   $��Profile��6A   #���  6S     settings# �  6�   ��6�   �� *ProfilePageCommand+�� 5O   "   $��20 20q�6,     TertiaryBackgroundColor#���  6;   5R      �� 5T      $��3��6%   $	 18��62   $	��110��6D   $��35��6P   #���  6\   $��Right=�6�   $��0 0 20 0q�6�   ._�5U   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5V   &   F�   sun#���  6+   $��16��6H   $��16��6T    �� Stretch$ UniformToFill=�6_     PrimaryYellowColor#���  6w   $��Center=�6�   d� 5W   &   -   5         d�Name$ Themes��5W   3    d� 	IsChecked$ FalseY�5X   #   $��Right=�5Y   #     ToggleButtonStyle#���  5Z   #   $��	10 0 10 0q�5[   #   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5\   *   +  %Microsoft.Xaml.Behaviors.EventTrigger  5]   .      	EventName$ Click��6=   *  $Microsoft.Xaml.Behaviors.TriggerBase    Actions.  5^   2   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  !   Command! 5_   5   �� *ThemesChangeCommand+5`   /   5b   '   F� 5c   &     moon#���  6+   $��16��6I   $��16��6U   $
 Fill=�6`     PrimaryWhiteColor#���  6o   $��Center=�6�   5d   #   " J� BitmapEffect" 5e   "   F� 5f   &   # F� ShadowDepth$# 1Q�5g   -   $ F� 	Direction$$ 0Q�5h   -   % F� Color$% #5B8DEF��5i   -   & F� Softness$	& 0.8Q�5j   -   5l      5n      5o      5p      � 5r      $��1��6   .+�5s       � -   5        '  �Name$' 	MainFrame��5s      (  � NavigationUIVisibility$( Hidden=�60   5t      5u      5v      5w      5x      