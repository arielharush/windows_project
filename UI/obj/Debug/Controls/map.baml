   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:UI.ControlsUI.Controls  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5          UI.Controls.map   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:UI.Controls     5      `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5      <controls'using:Microsoft.Toolkit.Uwp.UI.Controls     5	      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      $	��796��5      $
��1101��5      .��5      � $��0,0,-118,10q�6     � ColumnDefinitions  5   
   �� 5      $	��816 �6   6-   �� 5      $	��184 �6   6-   .+�5   
   '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$
 map1��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$
 Road 6   $��0��6*   $��0��6:      	ZoomLevel$ 16Q�6G      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 31.7964453,35.2453997 6V      Children. 5      �� ,  &Microsoft.Maps.MapControl.WPF.MapLayer   Position$ -23.563802,-46.664343 5         PositionOriginB  <Microsoft.Maps.MapControl.WPF.Design.PositionOriginConverter$ BottomCenter 5      $	��400��66   $	��400��6B   $��Right=�6O   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	MapMarker=�6*   $��30��6;   $��30��6F   
	 �� Top$	 10��6R   5      5      �� 5   
   -   5        
 ��Name$
 minus��5      $��Minus��64   $
��Left=�6D   $��
744,10,0,0q�6_   $	��Top=�6s   $��62��6�   �� 5   
   -   5        $

 plus��5      $
��Plus��62   $
��Left=�6A   $��
744,47,0,0q�6\   $	��Top=�6p   $��62��6�   �� 5   
   -   5         ��Name$ ProductTextBox��5      $��1��6*   $
��Left=�6:   $��23��6U   $��	10,28,0,0q�6a    �� TextWrapping$
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5    
   -   5        $
 Search_by_product��5       $��search��6,   $��0q�6]   $��8(�6i   $��1��6v   $
��Left=�6�   $��
135,19,0,0q�6�   $	��Top=�6�   $��44��6�   �� 5!   
   -   5         ��Name$ label��5!      $��Search by product��6   $��1��6;   $
��Left=�6K   $��10,0,0,0q�6f   $	��Top=�6x   �� 5"   
   -   5        $ label1��5"      $��Search by shop��6    $��1��69   $
��Left=�6I   $��
10,146,0,0q�6d   $	��Top=�6x   �� 5#   
   -   5        $ textboxShopname��5#      $��1��6+   $
��Left=�6;   $��23��6V   $��	5,229,0,0q�6b   $
 Wrap=�6u   $	��Top=�6�   $	��120��6�   �� 5$   
   -	   5        $ label2��5$      $��	Shop name��6    $��1��64   $
��Left=�6D   $��	0,200,0,0q�6_   $	��Top=�6r   �� 5%   
   -
   5        $
 
shopSearch��5%      $��search��6>   $��0q�6O   $��8(�6[   $��1��6h   $
��Left=�6x   $��135,220,0,0q�6�   $	��Top=�6�   $��44��6�   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ datagridShops��5'         
IsReadOnly .    AutoGenerateColumns .  $��0,393,-207,0q�6w   $��1��6�   ��5(      �� 5)       �� 
TargetType)	  #System.Windows.Controls.DataGridRow" 	 6   .�5*      -   5        5+         Columns 5/      0
  *System.Windows.Controls.DataGridTextColumn
  50      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+6J   
  51      $
 Name��6%    63   �� *name+6N   4  .System.Windows.Controls.DataGridTemplateColumn  52      $ Address��6*      CellTemplate 53      �� 54      .R�55      ]� .+�56   "   �� $��-5,-6q�6P   ��6(   ��  �� Path$ address.street�6a   �� 57   "   $��  ��6(   $��-5,-6q�65   6F   �� 58   "   $��-5,-6q�6M   ��6(   �� $ address.num�6_   �� 59   "   $��,��6(   $��-5,-6q�64   6E   �� 5:   "   $��-5,-6q�6N   ��6(   �� $ address.city�6`   5;      5<      5>      
  5?      $ Phone��6%    64   �� *phone+6P   
  5@      $ WebSite��6%    66   �� *	webSite+6T   
  5A      $ FaceBook��6%    67   �� *
faceBook+6V   
  5B      $ latitude��6%    67   �� *address.latitude+6^   
  5C      $ 	longitude��6%    68   �� *address.longitude+6`    � ContextMenu 5I      �� 5J      ��6   ��  �� RelativeSource �� *Self+5L      5N      5Q      5R      