   M S B A M L   `   `   `  ����G  CMatricaNyilv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MatricaNyilvMatricaNyilv  5   	       MatricaNyilv.Kategoriak   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MatricaNyilv     5   	   -   5          � Title$  Kategóriák��5   	   $	��500��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Kategoria_tabla��5      $��0��6,   $��1��69   $��2��6I   $��Arial)�6Z   $��15(�6m   $��10q�6{      
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .  $
��Auto��6�   $
��Auto��6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   	   SelectionMode$	 Single=�6�   6  �� 5   
   $��0��6   $��0��6"   .+�5      �� 
 �� Orientation$
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5      �� -   5         ��Name$ mezo1��5      $��Kategória ID:��6'   $	��150��6?   $��Arial)�6K   $��20(�6^   $��10q�6l   �� 5      -   5        $ mezo2��5      $�� ��6'   $	��150��62   $��Arial)�6>   $��20(�6Q   $��10q�6_   5      �� 5      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5      �� -   5        $ mezo3��5      $��Kategória név:��6'   $	��150��6@   $��Arial)�6L   $��20(�6_   $��10q�6m   �� 5      -   5        $ mezo4��5      $�� ��6'   $	��150��62   $��Arial)�6>   $��20(�6Q   $��10q�6_   5      �� 5       $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5!      �� -   5         ��Name$ torles_gomb��5!      $��Kategória törlése��6.   $	��150��6J   $��45��6V   $��Arial)�6b   $��13(�6u   $��10q�6�   6�   5#      5$      �� 5&   
   $��1��6   $��0��6"   .+�5'      �� $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5(      �� -   5        $ mezo5��5(      $��Kategória név:��6'   $	��150��6@   $��Arial)�6L   $��20(�6_   $��10q�6m   �� 5)      -	   5         ��Name$ szoveg1��5)      $	��200��6+   $��Arial)�67   $��20(�6J   $��10q�6X   5*      �� 5,      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5-      �� -
   5        $ Kategoria_Rogzitese��5-      $��Kategória rögzítése��66   $	��150��6T   $��45��6`   $��Arial)�6l   $��13(�6   $��10q�6�   6�   �� 5.      -   5        $ Kategoria_Modositas��5.      $��Kategória módosítása��66   $	��180��6U   $��45��6a   $��Arial)�6m   $��13(�6�   $��10q�6�   6�   5/      �� 51      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�52      �� -   5        $ Tartalom_Torles��52      $��Tartalom törlése��62   $	��150��6M   $��45��6Y   $��Arial)�6e   $��13(�6x   $��10q�6�   6�   53      �� 55      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�56      �� -   5        $ vissza_gomb��56      $��Vissza��6.   $	��150��6?   $��45��6K   $��Arial)�6W   $��13(�6j   $��10q�6x   6�   58      5:      5;      5<      