   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   E ABillSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BillSystem
BillSystem 5   	      BillSystem.BillWindow   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BillSystem     5   	   -   5          � Title$  Bill Window��5
   	   $��397.86��6   $��629.302��6-   (   "MahApps.Metro.Controls.MetroWindow   IsMinButtonEnabled .      IsMaxRestoreButtonEnabled .   � 
ResizeMode$ CanMinimize=�6z    � WindowStartupLocation$ CenterScreen=�6�   .��5      � $	��363��6   $	��Top=�6    � ColumnDefinitions 5   
   �� 5      $
��221* �6   �� 5      $
��400* �6   .+�5   
   �� $
��Left=�6<   $��23��6W   $��	35,42,0,0q�6c    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $	��126��6�   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Bill No��6�      WatermarkAlignment$ Justify=�6�   	 �� TextAlignment$	 Center=�6  
 � DataContext
 6   �� *CurrentLocation+��6$  �� *1+ �� Mode$ TwoWay=� �� ValidatesOnExceptions . �� 5   
   $
��Left=�6   $��	35,92,0,0q�6/   $	��Top=�6B   $	��438��6Z   $��2��6f   $ Select the Company��6z   $ Justify=�6�   �� 5   
   $
��Left=�6   $��
35,142,0,0q�6.   $	��Top=�6B   $	��177��6Z   $ Select the Bowser��6f   $ Justify=�6�   �� 5   
   $
��Left=�6   $��	0,142,0,0q�6.   $	��Top=�6A   $	��251��6Y   $ Select the Employee��6e   $ Justify=�6�   $��1��6�   �� 5   
   $
��Left=�6   $��23��6.   $��
35,197,0,0q�6:   $
 Wrap=�6N   $	��Top=�6b   $	��177��6z   $ Quntity��6�   $ Justify=�6�   $	 Center=�6�   �� 5   
   $
��Left=�6   $��23��6.   $��	0,197,0,0q�6:   $
 Wrap=�6M   $	��Top=�6a   $	��251��6y   $ 
Bill Total��6�   $ Justify=�6�   $	 Center=�6�   $��1��6�   �� 5   
   -   5        $
��Save��5      $
��Left=�6    $��
35,274,0,0q�6;   $	��Top=�6O   $	��106��6g    J� RenderTransformOrigin$ -1.427,0.444&�6s   $��42��6�   6�   �� 5   
   $��Clear��6   $
��Left=�6!   $��165,274,0,0q�6<   $	��Top=�6Q   $	��106��6i   $ -1.427,0.444&�6u   $��42��6�   $��2��6�   �� 5   
   $��Delete��6   $
��Left=�6"   $��
75,274,0,0q�6=   $	��Top=�6Q   $	��106��6i   $ -1.427,0.444&�6u   $��42��6�   $��1��6�   5      5      