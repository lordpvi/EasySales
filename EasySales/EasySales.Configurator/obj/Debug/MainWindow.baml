   M S B A M L   `   `   `  ����Q  MEasySales.Configurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EasySales.ConfiguratorEasySales.Configurator  5   	   K*clr-namespace:EasySales.Configurator.NodesEasySales.Configurator.Nodes  5   	   '    !EasySales.Configurator.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EasySales.Configurator     5   	   <nodes*clr-namespace:EasySales.Configurator.Nodes     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $
��auto �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5       $
��auto �6   6.   �� 5!      6!   .+�5$   
   R� -   5        $��ConfigurationTree��5$      $��0��6,   $��0��69   ��6I   ��  �� Path$ Nodes� � 	Resources 5%       �� DataType+   %EasySales.Configurator.Nodes.NodeBase �� ItemsSource �� Orientation � ContextMenu	 m� Command   contextMenu��%�  (��       5&   +   *, +)&	  C    �� 6   "  6+    6N   �� *
ChildNodes+.R�5'      �� $ 
Horizontal=�6!   .+�5(      �� ��6$   �� $
 Name� 5)      �� 5*   "   ��6.   �� $ Actions���5+   &   �� 5,   *   .R�5-   .   m� ��67   �� *Name+	 6O   �� *	Command+5.   +   50   #   52      53      54      �� 55      ��62   �� $ Actions�56      57      58      &   System.Windows.Controls.DataGrid  59   
   $��2��6   $��0��6    
   AutoGenerateColumns
 . ��60   �� $ 
Properties�5>      �� 5?   
   $��0��6   $��2��6"   $��2��62   .+�5@      �� $��Data editor��6   6,   5A      �� 5C   
   $��1��6   $��0��6$   $��5��64   $��Center=�6?   $��Stretch=�6Z   6{   �� 5D   
   $��0��6   $��1��6$   $��3��64   $��5��6E   $��Stretch=�6O   $��Center=�6k   6�   5E      5F      