   M S B A M L   `   `   `  ����J  FMiniProjekatHCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MiniProjekatHCIMiniProjekatHCI  5   	   l hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 65        MiniProjekatHCI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MiniProjekatHCI     5   	   �DVC{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     65     � Title$  Mini Projekat HCI��5   	   $	��450��6#   $	��800��60   .��5	      � -   5        $��grid1��5	      $��10,20,10,100q�6   $	��Top=�6/    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��
cmbContent��5   L    �� SelectedValuePath$ Content��6   $��1��6/   $��1��6<   .@�5      �� .��6   Potrošačke Cene6,   �� 5      .��6   	Inflacija6&   �� 5      .��6   Zarada6#   5      �� 5   
   -   5        $��	cmbPrikaz��5   M   $ Content��6   $��1��60   $��0��6=   .@�5       �� .��6   Tabelarni Prikaz6-   �� 5!      .��6   Grafikon Prikaz6-   �� 5"      .��6   Linijksi Grafikon Prikaz65   5#      �� 5$   
   $��	20,10,0,0q�6   $��0��6#   $��1��60   $!��Odaberite sadržaj prikaza:��6@   �� 5%   
   $��	20,10,0,0q�6   $��0��6#   $��0��60   $��Odaberite vrstu prikaza:��6@   �� 5&   
   -   5        $��3��5&      $��2��6!   $��80��6.   $��3q�6<   $��Potvrdi izbor��6G   6_   �� 5(      $��
20,10,0,10q�6   $��2��6(   $��0��65   $��Odaberite pocetni datum:��6E   �� 5)      $��
20,10,0,10q�6   $��2��6(   $��1��65   $��Odaberite krajnji datum:��6E   �� 5*      -   5        $��
prvi_datum��5*      $��
20,10,0,10q�6)   $��4��6=   $��0��6J   $��Center=�6Z   �� 5+   
   -   5        $��drugi_datum��5+      $��
20,10,0,10q�6&   $��4��6:   $��1��6G   $��Center=�6W   5-      5.      