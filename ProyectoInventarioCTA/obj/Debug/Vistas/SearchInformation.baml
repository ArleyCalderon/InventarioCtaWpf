   M S B A M L   `   `   `  ����P  LProyectoInventarioCTA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProyectoInventarioCTA.VistasProyectoInventarioCTA.Vistas  5      4    .ProyectoInventarioCTA.Vistas.SearchInformation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      6local*clr-namespace:ProyectoInventarioCTA.Vistas  5      $	��464��5	      $	��800��6   
�������  � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   6-   �� 5      $	��100 �6   6-   �� 5      $	��100 �6   6-   �� 5      $	��100 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5"   
   �� -   5        $��txtRadicado��5"   1   $��	10,10,0,0q�6   $	��140��6%    %  !MaterialDesignFloatingHintTextBox#��[  6D   $��0��6   $��0��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Código Act��6�   $
��Left=�6�   $��Center=�6�   6   �� 5#   
   $
��Left=�6   $��	20,10,0,0q�6+   $��0��6>   $��4��6K   $��2��6[   $	��Top=�6o   $
��Bold"�5$      $��15(�6!   $!��Información Inventario CTA��60   6X   �� 5%   
   -   5        $��
btnRefresh��5&       # MaterialDesignRaisedLightButton#��[ 5%      $��	Consultar��6J   $��0��6^   $��1��6k   $
��Left=�5&   #   $��13(�5'      $��	0,10,0,10q�68    � Cursor$
 Hand��6K   5(      �� 5)   
   -   5        $��btnModificar��5*      #��[ 5)      $��	Modificar��6J   $��0��6^   $��2��6k   $
��Left=�5*   %   $��13(�5+      $��	0,10,0,10q�6:   5,      �� 5-   
   -   5        $��
btnAgregar��5.      #��[ 5-      $��Agregar��6J   $��0��6\   $��3��6i   $
��Left=�5.   #   $��13(�5/      $��	0,10,0,10q�68   50      &   System.Windows.Controls.DataGrid  51   
   -   5        $��datagridinventario��51         AutoGenerateColumns .  $��5��52         
IsReadOnly . $��2��53      
�������	 �� SelectedItem	 54      �� *CurrentTicket+
   Columns
 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Código act��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
CÓDIGOACT+6Y     57      $ Área responsable��6%    6?   �� *ÁREARESPONSABLE+6e     58      $ Responsable��6%    6:   �� *RESPONSABLE+6\     59      $ Estado��6%    65   �� *ESTADO+6R     5:      $ Observaciones��6%    6<   �� *OBSERVACIONES+6`   5=      5>      5?      