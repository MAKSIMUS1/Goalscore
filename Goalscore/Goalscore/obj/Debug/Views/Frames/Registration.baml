   M S B A M L   `   `   `  ����D  @Goalscore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Goalscore.Views.FramesGoalscore.Views.Frames  5      )    #Goalscore.Views.Frames.Registration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Goalscore.Views.Frames     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5        N� Title$  Registration��5
       � 	Resources 5         PrimaryBackgroundColor �� Color  PrimaryBlueColor  PrimaryGrayColor  SecundaryBlueColor  SecundaryGrayColor  TertiaryBlueColor  TertiaryGrayColor  PrimaryTextColor  TextBoxStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name ��Name
 � Tag �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     �� 5   
   $ #FFFFFF��69   �� 5   
   $ #263FAA��63   �� 5   
   $ #64677A��63   �� 5   
   $ #004BFF��65   �� 5   
   $ #9295A5��65   �� 5   
   $ #496FFF��64   �� 5   
   $ #CECECE��64   �� 5   
   $ #FFFFFF��63   �� 5   
   " ��6%   .�5      ��  � ��
 ���� 6+   �� 5        � ��$ 2q�60   �� 5!       � ��# �  6,   �� 5"       � ��$ 5.2 3.2q�6(   �� 5#       � ��$ /Resources/Fonts/#Poppins)�6+   �� 5$       � ��$
 Thin"�6+   �� 5%       �@�Cursor$ IBeam��6'   �� 5&       � ��# �  6+   �� 5'       � ��$	 300��6&   �� 5(       � ��$
 Auto��6'   �� 5)       � ��$ 40��6*   �� 5*       � ��$	 300��6)   �� 5+       �@J�	AllowDrop . 6*   �� 5,       �@��PanningMode$ VerticalFirst=�69   �� 5-       �@��IsFlicksEnabled .  67   �� 5.       � ��$
 Left=�6;   �� 5/       � �� 50      �� 51      " ��6&   .R�52      �� $ 	txtBorder��6!   #���   53   !   $ 5��54   !   #��z��55   !   #��z��56   !   #��z��57   !   #��z��58   !   	 . ._�5:      � #��z��6#   .+�5;   "   �� $
 PART_ContentHost��6/   |�.  $��Hidden=�5=   /   $��Hidden=�5>   /   $
��-2 1q�5?   /   �� 5@   "   $ WaterMarkerLabel��6(   #��z 5A   (   #��z��5B   (   #��z��5C   (   #��z��5D   (   $y�	Collapsed=�5E   (   #��z��5F   (   #��z��5G   (   5H      5K       5L      ]� 5M       5N   "   �� 5O   &    � ��$  ��6@   ./�5Q   "   �� $ WaterMarkerLabel��5R   )    � y�$ Visible=�5S   )   5T      P� 5U       �@J�IsMouseOver . . �5V   "   �� # �  6@    � ��5W      P� 5X       �@J�IsKeyboardFocused . . �5Y   "   �� # �  5Z   )    � ��5\      5^      5`      5c      5e      .��5f      � $��Center=�6   $��Center=�6(   .+�5h   
   �� $	��600��6   $	��400��6!   .+�5i      �� $��Center=�6   $��Center=�63   $	��160��5j      $��	0 0 240 0q�6$   $��26(�67   $��SemiBold"�5k      $��Registration��6.   #���  5l      �� 5m      -   5         ��Name$ LoginTextBox��5m      $ Login��6,   $
��Left=�5n      $	��Top=�5o      $��	20 20 0 0q�5p       �� TextWrapping$ NoWrap=�5q      #���  5r      �� 5s      -   5        $ PasswordTextBox��5s      $ Password��6/   $
��Left=�5t      $	��Top=�5u      $��	20 20 0 0q�5v      $ NoWrap=�5w      #���  5x      �� 5y      -   5        $ PasswordAgainTextBox��5y      $ Password again��64   $
��Left=�5z      $	��Top=�5{      $��	20 20 0 0q�5|      $ NoWrap=�5}      #���  5~      �� 5      $��Registration��6   $
��Left=�6,   $��40��6G   $��100 20 0 16q�6S   $	��Top=�6h   $	��134��6�   #���  5�      
�������$��20(�5�       	 RoundedButtonStyle#��� 	 6   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5�      +  %Microsoft.Xaml.Behaviors.EventTrigger  5�         	EventName$ Click��6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5�      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 5�      �� *RegistrationCommand+5�      5�      �� 5�      $��Login��6   #���  6%    5�        5�      $ 	MouseDown��6%   . 5�         5�      �� *ToLoginCommand+5�      5�      5�      5�      5�      