   M S B A M L   `   `   `  ����F  BGarbage IDE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Garbage_IDEGarbage_IDE  5   	   a ]PresentationFramework.Aero, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5          Garbage_IDE.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Garbage_IDE     5   	   ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5        � Title$  Garbage IDE��5   	   $	��450��6   $	��800��6*   ���#353535 � Icon$  /images/App_logo_black.ico��5      .��5      � -   5         �Name$ 	main_grid��5       � RowDefinitions 5      �� 5      $��* �6    � ColumnDefinitions 5      �� 5      $��* �6   .+�5      � -   5        $ options_grid_top��5   	   ���#202020$��30��68   $	��Top=�6G    5      �� 5      $
��Auto �6    5      �� 5      $��* �6   .+�5       a� ���#202020$	��Top=�6'   .+�5!      c� -   5        ���#202020 `� IsLocked$
 True��5!   #   .@�5"      o� ���#202020 c� OverflowMode$ Never=�6!    � 	Resources 5#       �� 
TargetType	 �� Property
 �� Value��%�   'm�       �� 5$   	   " m�6   .�5%   
   �� 	 � ��
 �#2020206'   �� 5&   
   	 � ��
 �#FFFFFF6'   5'   
   5(   	   .@�5*      m� $
��File��6   $��0q�6    5+   	   ��%�   'm�       �� 5,   
   " m�6   .�5-      �� 	 � ��
 �#2020206(   �� 5.      	 � ��
 �#FFFFFF6(   �� 5/      	 � ��
 �#2020206)   �� 50      	 � ��$
 0q�6-   51      52   
   .@�54   	   m� $	��New��6   $��0q�6   m� 55   	   $
��Open��6   $��0q�6    56   	   m� 58      $
��Edit��6   $��0q�6   m� 59      $
��View��6   $��0q�6   5:      5;      5<      5=      � 5?      -   5        $ lower_code_area_grid��5?   	   $��0,23,0,0q�6'    5A      �� 5B      $
��Auto �6   $��0��6$   $	��300��61   �� 5C      $��3 �6   �� 5D      $
��Auto �6   .+�5G      �� -   5         ��Name$ grid_splitter��5G      $��Center=�6)   $��Stretch=�6F   $��1��6b   $��3��6r   ���#3385FF6|   �� 5I      $��0��6   ���#2020206   � 5K      $��0��6
   $��2��6   .+�5L      �� -   5         ��Name$ code_textbox��5L      $
��Left=�6$   $��2��6?   ���#FFFFFF���#303030$��0q�6y   $��0,0,0,0q�6�   5M      5O      5Q      5R      