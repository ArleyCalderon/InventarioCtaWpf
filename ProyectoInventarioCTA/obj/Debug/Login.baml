   M S B A M L   `   `   `  ����P  LProyectoInventarioCTA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProyectoInventarioCTA.VistasProyectoInventarioCTA.Vistas  5      (    "ProyectoInventarioCTA.Vistas.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5      6local*clr-namespace:ProyectoInventarioCTA.Vistas  5      $	��400��5	      $	��300��6     � Title$  Login��5
       � WindowStyle$
 None=�5       � WindowStartupLocation$ CenterScreen=�6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   �� 5      $k epack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.PasswordBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Label.xaml?�6%   %    5      .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $��50 �6   6*   �� 5!      $��50 �6   6*   �� 5"      $��50 �6   6*   �� 5#      $
��Auto �6   6,   .+�5'   
   �� -   5        $��Title_Radicado��5'      $��24(�6&   $��Center=�64   $��0��6Q   $��0��6^   $��2��6n   $��92,0,80.333,53.667q�6�   $��81��6�   .��6�   Login6�   �� 5(   
   -   5         ��Name$ txtUser��5(   �   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Usuario��6    %  !MaterialDesignFloatingHintTextBox#��[  6;   $��2��6v   $��2��6�   $��0��6�   6�   G� 5)   
   -   5        
 G�Name$
 txtPassword��5)   �   $	 Contraseña��6    ) %MaterialDesignFloatingHintPasswordBox#��[ 6B   $��2��6�   $��3��6�   $��0��6�   6�   �� 5*   
   -   5        $��Ingresar��5*   i    # MaterialDesignRaisedLightButton#��[ 6   $��4��6L   $��0��6Y   $��	5 30 5 30q�6�    � Cursor$
 Hand��6�   .��6�   
Ingresar6�   �� 5+   
   -   5        $��Cancelar��5+   i   #��[ 6   $��4��6L   $��1��6Y   $��	5 30 5 30q�6�   .��6�   
Cancelar6�   �� 5,   
   -   5         ��Name$ image��5,   T   $��Imagenes\Login.png��6    �� BitmapScalingMode$
 Fant=�6,   $��2��6c   $
��Left=�6w   $	��100��6�   $��	73,52,0,0q�6�   $��3��6�   $	��Top=�6�   $	��100��6�   5-      5.      