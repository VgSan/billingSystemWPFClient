   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   E ABillSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BillSystem
BillSystem 5   	      BillSystem.MainWindow   5   	   HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BillSystem     5   	   4mah*http://metro.mahapps.com/winfx/xaml/shared   5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   
�������(   "MahApps.Metro.Controls.MetroWindow    IsMaxRestoreButtonEnabled .     IsMinButtonEnabled .   � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5      3   -MahApps.Metro.Converters.ClockDegreeConverter   ClockDegreeConverter��%   &	          5   
   6#   5      .��5      � $	��600��6   $	��400��6    � ColumnDefinitions 5   
   �� 5      $
��195* �6   �� 5      $
��322* �6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5   
   !   MahApps.Metro.Controls.Tile  -   5          Name$ 
BillWindow��5         Title$ Create Bill��6,   $	��225��5      $	��100��5      	   Count$
	 Bill��5      $��59,27,233,192q�6   ���	#CC119EDA$��2��6^   
 � BindingGroup
 5      &   System.Windows.Data.BindingGroup  5      5        5   
   -   5        $ Company��5      $	��100��5      $	��100��5       $	  ��5!      $��184,159,233,60q�6   $��2��61   6E     5"   
   -   5        $ Bowser��5"      $	��100��5#      $	��100��5$      $	  ��5%      $��59,159,36,60q�6   6/     5&   
   $ Employee��6   $	��100��5'      $	��100��5(      $	  ��5)      $��151,27,71,192q�6   $��1��60     5*   
   $ Hello!��6   $	��100��5+      $	��100��5,      $	 1��5-      $��151,159,71,60q�6   $��1��6.   5.      51      