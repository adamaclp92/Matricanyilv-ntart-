   M S B A M L   `   `   `  ����G  CMatricaNyilv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MatricaNyilvMatricaNyilv  5   	        MatricaNyilv.MatricaFajtak   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MatricaNyilv     5   	   -   5          � Title$  Matrica fajták��5   	   $	��500��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Matrica_Fajta_Tabla��5      $��0��60   $��1��6=   $��2��6M   $��Arial)�6^   $��15(�6q   $��10q�6      
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .  $
��Auto��6�   $
��Auto��6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   	   SelectionMode$	 Single=�6�   6  �� 5   
   $��0��6   $��0��6"   .+�5      �� 
 �� Orientation$
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5      �� -   5         ��Name$ mezo1��5      $��Matrica fajta ID:��6'   $	��200��6C   $��Arial)�6O   $��20(�6b   $��10q�6p   �� 5      -   5        $ mezo2��5      $�� ��6'   $	��150��62   $��Arial)�6>   $��20(�6Q   $��10q�6_   5      �� 5      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5      �� -   5        $ mezo3��5      $��Matrica fajta név:��6'   $	��200��6D   $��Arial)�6P   $��20(�6c   $��10q�6q   �� 5      -   5        $ mezo4��5      $�� ��6'   $	��150��62   $��Arial)�6>   $��20(�6Q   $��10q�6_   5      �� 5       $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5!      �� -   5         ��Name$ torles_gomb��5!      $��Matrica fajta törlése��6.   $	��150��6N   $��45��6Z   $��Arial)�6f   $��13(�6y   $��10q�6�   6�   5#      5%      �� 5'   
   $��1��6   $��0��6"   .+�5(      �� $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5)      �� -   5        $ mezo5��5)      $��Matrica fajta név:��6'   $	��200��6D   $��Arial)�6P   $��20(�6c   $��10q�6q   �� 5*      -	   5         ��Name$ szoveg1��5*      $	��150��6+   $��Arial)�67   $��20(�6J   $��10q�6X   5+      �� 5-      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�5.      �� -
   5        $ Matrica_Fajta_Rogzitese��5.      $ ��Matrica fajta rögzítése��6:   $	��150��6\   $��45��6h   $��Arial)�6t   $��13(�6�   $��10q�6�   6�   �� 5/      -   5        $ Matrica_Fajta_Modositas��5/      $!��Matrica fajta módosítása��6:   $	��180��6]   $��45��6i   $��Arial)�6u   $��13(�6�   $��10q�6�   6�   50      �� 52      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�53      �� -   5        $ Tartalom_Torles��53      $��Tartalom törlése��62   $	��150��6M   $��45��6Y   $��Arial)�6e   $��13(�6x   $��10q�6�   6�   54      �� 56      $
 
Horizontal=�6   $	��Top=�62   $
��Left=�6J   .+�57      �� -   5        $ vissza_gomb��57      $��Vissza��6.   $	��150��6?   $��45��6K   $��Arial)�6W   $��13(�6j   $��10q�6x   6�   59      5;      5<      5=      