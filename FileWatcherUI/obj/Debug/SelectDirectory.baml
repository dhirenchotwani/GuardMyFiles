   M S B A M L   `   `   `  ����H  DFileWatcherUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FileWatcherUIFileWatcherUI  5      #    FileWatcherUI.SelectDirectory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FileWatcherUI     5        N� Title$   Select Directory to Watch!��5	      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6    $��Center=�6-   $��Center=�6H   
���  ��$��	0,110,0,0q�6v   .��6�   *(Select the Directory you wish to Monitor6�   �� 5   
   -   5         ��Name$ SelectDButton��5      $��0��6(   $��Select Directory��6Q   $��1��6l   $��Center=�6y   $��Center=�6�   $	��175��6�   $��35��6�   6�   �� 5   
   -   5         ��Name$ SelectedDirectory��5      $��0��6+   $��2��6;   $��Center=�6H   $��Center=�6c   
���  ��$��	0,110,0,0q�6�   .��6�   Selected Directory is :6�   �� 5   
   -   5        $ MonitorButton��5      $��0��6(   $��Start Monitoring��6P   $��3��6k   $��Center=�6x   $��Right=�6�   $	��175��6�   $��35��6�   6�   5      5      