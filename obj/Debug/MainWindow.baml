   M S B A M L   `   `   `  ����K  GPersonalFirewall, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalFirewallPersonalFirewall  5   	   !    PersonalFirewall.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalFirewall     5   	   -   5          � Title$$  第17组作品-个人防火墙��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ btnStartFilter��5
      $��启动过滤��6)   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f   $	��200��6~   $��32(�6�   6�   �� 5   
   -   5        $ btnStopFilter��5      $��停止过滤��6(   $
��Left=�67   $��	10,60,0,0q�6R   $	��Top=�6e   $	��200��6}   $��32(�6�   {�.  6�   �� 5   
   -   5        $ 
btnAddRule��5      $��添加规则��6%   $
��Left=�64   $��
10,140,0,0q�6O   $	��Top=�6c   $	��200��6{   $��32(�6�   6�   �� 5   
   -   5        $ btnDeleteRule��5      $��删除规则��6(   $
��Left=�67   $��
10,190,0,0q�6R   $	��Top=�6f   $	��200��6~   $��32(�6�   6�   A� 5   
    A� Columns$ 3��6   �� 5   
   -   5         ��Name$ lvRules��5      $
��Left=�6$   $	��399��6?   $��
215,10,0,0q�6L   $	��Top=�6`   $	��567��6x   $��16(�6�    �� View 5      �� 5      5      5      5      5      