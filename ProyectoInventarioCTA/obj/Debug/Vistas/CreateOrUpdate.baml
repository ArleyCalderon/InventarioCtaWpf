   M S B A M L   `   `   `  ����P  LProyectoInventarioCTA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProyectoInventarioCTA.VistasProyectoInventarioCTA.Vistas  5   	   1    +ProyectoInventarioCTA.Vistas.CreateOrUpdate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   6local*clr-namespace:ProyectoInventarioCTA.Vistas  5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   $��Arial Rounded Mt Bold)�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Label.xaml?�6%   %    5      .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5!   
   �� 5"      $
��Auto �6   6,   �� 5#      $
��Auto �6   6,   �� 5$      $
��Auto �6   6,   �� 5%      $
��Auto �6   6,   �� 5&      $
��Auto �6   6,   �� 5'      $
��Auto �6   6,   �� 5(      $
��Auto �6   6,   �� 5*      $
��Auto �6   6,   .+�5,   
   �� -   5        $��Title_Radicado��5,      $��24(�6&   $��Center=�64   $��0��6Q   $��0��6^   $��2��6n   .��6�   Nuevo Registro6�   �� 5-   
   -   5        	 ��Name$	 	txtCodigo��5-   �   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Código Act��6    % !MaterialDesignFloatingHintTextBox#��[ 6>   $��1��6y   $��1��6�   $��0��6�   6�   �� 5.   
   -   5        $	 txtAreaResponsable��5.   �   $
 Área Responsable��6   #��[ 6D   $��1��6   $��2��6�   $��0��6�   6�   �� 5/   
   -   5        $	 txtResponsable��5/   �   $
 Responsable��6   #��[ 6?   $��1��6z   $��3��6�   $��0��6�   6�   �� 50   
   -   5        $	 	txtEstado��50   �   $
 Estado��6   #��[ 6:   $��1��6u   $��4��6�   $��0��6�   6�   �� 51   
   -   5        $	 txtObservaciones��51   �   $
 Observaciones��6   #��[ 6A   $��1��6|   $��5��6�   $��0��6�   6�   �� 52   
   -   5        $��SaveRadicado��52   /   $��8��6   $��0��6   $��0 10 5 0q�6^   .��6p   	Guardar6y   �� 53   
   -   5        $��CancelRadicado��53   /   $��8��6   $��1��6   $��5 10 0 0q�6b   .��6t   
Cancelar6~   54      56      