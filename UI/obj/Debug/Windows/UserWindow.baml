   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:UI.Windows
UI.Windows  5   	       UI.Windows.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:UI.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  
UserWindow��5   	   $��701.471��6   $��1270.588��6-      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��Center=�6    $��20(�6;   $��Champagne & Limousines)�6I   $
��20 0q�6q    J� RenderTransformOrigin$ 0.833,0.208&�6   $	��110��6�   5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5        $��30��5      $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�62   5      �� 5      -   5         ��Name$ ButtonFechar��5      $��30��63   $��30��6>   $��0q�6w   
���������6J   Z� ��6`   Z� .��5        $ WindowClose=�62   5      5      5       5!      � 5#   
   $��
250 55 0 0q�6    � ColumnDefinitions 5$      �� 5%      $
��131* �6#   �� 5&      $
��683* �6#   .+�5(      �� -   5        $��Scrol��5(      $��2��6(   .��5)      � -   5         �Name$ GridPrincipal��5)      $��Center=�6.   $��Center=�6K   5*      5+      � 5-   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5.      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        	  Name$	 TrainsitionigContentSlide��5.   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffect
 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5/      � -   5        $ 
GridCursor��5/      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   50      � 51      -   5         �Name$
 work��53       � ToolTip$ Work on find testers��51       � IsIndeterminate .  % !MaterialDesignCircularProgressBar#��[ 52      $y�Hidden=�53      $��20��6&   
�������$��20��6E   $��200,10,10,645q�6P   � 54      -   5        $ ProgressBarDistance��54       � Maximum$	 100Q�67    � Value$ 0Q�6E   $y�	Collapsed=�6O    .   � Orientation$ 
Horizontal=�55      $��10��56      $��10,30,69,655.2q�57      �� 59      -	   5         ��Name$ ListViewMenu��59      $��	0,100,0,0q�6-   
�������$��Champagne & Limousines)�6W   $��18(�6    �� SelectedIndex$ 0��6�   .@�5:      �� $��60��6   .��5;      �� $ 
Horizontal=�6!   .+�5<        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5=      $
��Home��6$   $��17(�60   $��Center=�6>   $
��20 0q�6Y   5?      5@      5C      5D      5F      5G      