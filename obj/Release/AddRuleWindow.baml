   M S B A M L   `   `   `  ���� K  GPersonalFirewall, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalFirewallPersonalFirewall  $    PersonalFirewall.AddRuleWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:PersonalFirewall       � Title$  添加规则��$��275.968��$��611.406��$��32(� � WindowStyle$ 
ToolWindow=�.��� .+��� $��IP地址：��$
��Left=�$��	10,10,0,0q�$	��Top=��� $��传输协议：��$
��Left=�$��	10,66,0,0q�$	��Top=��� $��端口号：��$
��Left=�$��
10,122,0,0q�$	��Top=��� -    ��Name$
 tbIP��$
��Left=�$��51��$��
185,10,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��400��$��Bottom=��� -   $ tbPort��$
��Left=�$��51��$��185,122,0,0q�$
 Wrap=�$	��Top=�$	��400��$��Bottom=��� -    ��Name$ 
btnConfirm��$��确认��$
��Left=�$��
10,178,0,0q�$	��Top=�$	��285���� -   $ 	btnCancel��$��取消��$
��Left=�$��300,178,0,0q�$	��Top=�$	��285���� -    ��Name$ 
cbProtocol��$
��Left=�$��
185,70,0,0q�$	��Top=�$	��400�� �� SelectedIndex$ 2��.@��� $	��TCP��$
��Left=�$	��398���� $	��UDP��$
��Left=�$	��398���� $	��ALL��$
��Left=�$	��398��