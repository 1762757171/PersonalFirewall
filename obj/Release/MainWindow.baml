   M S B A M L   `   `   `  ���� K  GPersonalFirewall, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalFirewallPersonalFirewall  !    PersonalFirewall.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:PersonalFirewall     -     � Title$  
MainWindow��$	��450��$	��800��.��� .+��� -    ��Name$ btnStartFilter��$��启动过滤��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��200��$��32(��� -   $ btnStopFilter��$��停止过滤��$
��Left=�$��	10,60,0,0q�$	��Top=�$	��200��$��32(�{�.  �� -   $ 
btnAddRule��$��添加规则��$
��Left=�$��
10,140,0,0q�$	��Top=�$	��200��$��32(��� -   $ btnDeleteRule��$��删除规则��$
��Left=�$��
10,190,0,0q�$	��Top=�$	��200��$��32(�A�  A� Columns$ 3���� -    ��Name$ lvRules��$
��Left=�$	��399��$��
215,10,0,0q�$	��Top=�$	��567��$��16(� �� View �� .P��� $��IP地址�� �� Width$	 189���� $��	端口号��$	 189���� $��传输协议��$	 189��