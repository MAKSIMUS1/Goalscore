   M S B A M L   `   `   `  ����D  @Goalscore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Goalscore.Views.FramesGoalscore.Views.Frames  5      7 clr-namespace:Goalscore.CustomUIGoalscore.CustomUI  6:   +    %Goalscore.Views.Frames.MyPlayersFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Goalscore.Views.Frames     5      0fui clr-namespace:Goalscore.CustomUI     6:     N� Title$  MyPlayersFrame��5	      .��5      ��  �� CornerRadius$ 8��6      SecundaryBackgroundColor#���   6   ._�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ PlayersDataGrid��5        DataGridRowStyle1   RowStyle# �  5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5        DataGridCellStyle1   	CellStyle# �  5        DataGridStyle1#���  5      $��2��5      $��1��5      $��20 20 20 20q�5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        DescriptionColumn��,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    MinWidth$	 230Q�5   V   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 3* 6e   
   CellTemplate
 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��2q�5   )   
����� � �� Padding$ 2 2 2 2q�5   )   $ 2��5   )   ._�5!   &   �� $	��100��6,   $	��100��68   ��6E   �� *PlayerImage+5"   #   �� 5#   "    �� Padding$ 3 0 15 0q�6,   $	��110��6?   $
��Wrap=�6N   $
��Bold"�5%   ,     PrimaryTextColor#���  5&   ,   $��Center=�5'   ,   $��Center=�6I   ��5#   b   �� *Name+5'   I   5(      5)      5+        5-      -   5        ID_Title_Column�� . $	 3* 5-   T   
 5.      �� 5/      .R�50      �� $ Vertical=�6)   .+�51   "   �� $
��Wrap=�6-   $
��Bold"�52   ,   #���  53   ,   $��Center=�54   ,   $��Center=�6I   ��51   A   �� *ShortDateOfBirth+54   I   �� 55   "   �� 56   "   $
��Wrap=�6-   $
��Bold"�57   ,   #���  58   ,   $��Center=�59   ,   $��Center=�6I   ��56   A   �� *
Position+59   I   5:      5;      5=        5?      -   5        Nation_Image_Column�� . $	 * 5?   X   
 5@      �� 5A      .R�5B      �� $ Vertical=�6)   .+�5C   "   �� $��48��6(   $��32��63   ��6?   �� *NationalityImage+5D      5E      5G        5I      -   5        
TeamColumn�� . $	 230Q�5I   O   $	 3* 6^   
 5J      �� 5K      .R�5L      �� $ 
Horizontal=�6)   .+�5M   "   �� $��2q�5N   )   
����� �$ 2 2 2 2q�5P   )   $ 2��5Q   )   ._�5S   &   �� $	��100��6,   $	��100��68   ��6E   �� *	TeamImage+5T   #   �� 5U   "   $ 3 0 15 0q�6,   $	��110��6?   $
��Wrap=�6N   $
��Bold"�5V   ,   #���  5W   ,   $��Center=�5X   ,   $��Center=�6I   ��5Y   ,   �� *
TeamName+5Z      5[      5]        5_      -   5        Operations_Column�� . $
	 auto 5_   W   
 5`      �� 5a      .R�5b      �� $ 
Horizontal=�6)   .+�5c   "   )   #Goalscore.CustomUI.AddToFavoritesUI    Name$ StartButton��67   $��5q�5d   ;   $��30��5f   ;   $��30��6F     Star#��[ 5g   ;   	   Id 5e   ;   �� *Id+5h   #   5i      5j      5l      5o      5p      5q      