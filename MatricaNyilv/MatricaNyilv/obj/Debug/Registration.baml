   M S B A M L   `   `   `  ����G  CMatricaNyilv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MatricaNyilvMatricaNyilv  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   R       MatricaNyilv.Registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MatricaNyilv     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   3System&clr-namespace:System;assembly=mscorlib  6R   -   5          � Title$  Regisztráció��5	   
   $	��350��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ CanMinimize=�6^    � WindowStyle$
 None=�6x    � 	Resources 5
         
extiButton �� 
TargetType �� Property  PrimaryHueDarkBrush �� Value ! PrimaryHueDarkForegroundBrush3  -MaterialDesignThemes.Wpf.ButtonProgressAssist  PrimaryHueLightBrush �� BasedOn	 J� SnapsToDevicePixels
 �� StrokeDashArray  PrimaryHueMidBrush   PrimaryHueMidForegroundBrush+  %MaterialDesignThemes.Wpf.RippleAssist  SecondaryHueMidBrush  MaterialDesignDivider+  %MaterialDesignThemes.Wpf.ShadowAssist �� 
TargetType J� 	CacheMode �� RelativeSource A�Name J� Effect �� Path �� 	Converter9  3MaterialDesignThemes.Wpf.Converters.ShadowConverter �Name J� RenderTransformOrigin % !MaterialDesignCircularProgressBar � IsIndeterminate � Maximum � Minimum J� Opacity � Value �� Property �� ConverterParameter �� 	Converter7  1MaterialDesignThemes.Wpf.Converters.MathConverter   	Operation �� ScaleY �� ScaleX%  MaterialDesignThemes.Wpf.Ripple �� ContentStringFormat  J� Clip! �� ElementName" J� IsHitTestVisible# �� Triggers$ P� Property% P� Value& �� 
TargetName' N� EnterActions( g� Duration) W� From	* W� To+ �� TargetProperty, �� 
TargetName- N� ExitActions��%|  &	        �� 5   
   " ��6#   .�5      ��  � ��# �  6+   �� 5       � ��# �  6,   �� 5       � ��# �  6+   �� 5       �@ IndicatorForeground# �  6X    5      �� 5      " ��6   .�5      ��  � ��$ 56��6.   �� 5       � ��$ 56��6/    5      �� 5      " ��6    .�5      ��  �@�FocusVisualStyle 5   "   �� 5   &   .�5   *   ��  � �� 5   .   �� 5   2   .R�5   6   �� $��2q�6@   	 . #��� ��6f   $��1��6�   $	
 1 2R�6�   5   3   5   +   5    '   5"      �� 5#       � ��# �  6;   �� 5$       � ��# �  6<   �� 5%       � ��# �  6;   �� 5&       �@ Feedback
 �����6U   �� 5'       �@ IndicatorForeground# �  6h   �� 5(       �@ IndicatorBackground# �  6h   �� 5)       � ��$ 1q�6@   �� 5*       �@�Cursor$
 Hand��67   �� 5+       � ��$ Center=�6K   �� 5,       � ��$ Center=�6I   �� 5-       �@ ShadowDepth$ Depth2=�6X   �� 5.       � ��$ 1q�68   �� 5/       � ��$ 40��66   �� 50       � ��$ 40��67   �� 51       �@ Opacity$ 1Q�6\   �� 52       � �� 53   "   �� 54   &   " ��66   .R�55   *   � .+�56   .   ��  6?   �� *)'(materialDesign:ShadowAssist.CacheMode)+ �� *Self+.u�57   2   A� $ border��6:   #��z��6J   #��z��6n   #��z��6�    58   6   �� 59   :   $/ )(materialDesign:ShadowAssist.ShadowDepth)�6B    6s   �� *TemplatedParent+ 5:   >     5;   B   5=   ;   5?   3   5@   /   � 5A   .   $ ProgressBar��6:   $��Stretch=�6S  $��-8q�6g  $ 0.5,0.5&�6Y  #���  6y  $��Stretch=�6$  ��6O   �� *;9(materialDesign:ButtonProgressAssist.IndicatorBackground)+ �� *TemplatedParent+��6�   �� *;9(materialDesign:ButtonProgressAssist.IndicatorForeground)+ �� *TemplatedParent+ 6q  �� *75(materialDesign:ButtonProgressAssist.IsIndeterminate)+ �� *TemplatedParent+ 6�  �� */-(materialDesign:ButtonProgressAssist.Maximum)+ �� *TemplatedParent+ 6s  �� */-(materialDesign:ButtonProgressAssist.Minimum)+ �� *TemplatedParent+ 6�  �� */-(materialDesign:ButtonProgressAssist.Opacity)+ �� *TemplatedParent+ 6�  �� *-+(materialDesign:ButtonProgressAssist.Value)+ �� *TemplatedParent+��5B   2   �� 5C   6    � �� 5D   :   ��5E   >   8��6N    5G   :     5H   >   $	 Add=�6[   5J   7   z�5L   2   V� 5M   6   .~�5N   :   �� $ 0Q�6I   $ 0Q�6T   5O   7   y�5Q   2   �� 5R   6   $> 8(materialDesign:ButtonProgressAssist.IsIndicatorVisible)�6>    6~   �� *TemplatedParent+ 5S   :   �� 5T   >   5V   7   ��5X   2   �� 5Y   6    � �� 5Z   :   ��5[   >   8��6N    5]   :     5^   >   $	 Add=�6[   5`   7   5b   /   A� 5c   .   #��z��66   #��z��6Z   #��z��6�     5d   .   }�. #��z��6�   #��z��6�   # z 6�   |�.  #��z��6=  #��z��6�  #	 z	 6�  #��z��6�    6X   �� *RenderedGeometry+$! GeometryEllipse��6�  A� 5e   .   $ GeometryEllipse��66   |�.  
������ " .  6t   5f   +   # 5g   *   P� 5h   .   $ �@��IsDefaulted% . . �5i   2   �� $& border��6K   # � ��6_    � ��5j   /   P� 5k   .   $ � {�% .  . �5l   2   ��  �@J�Opacity$
 0.23Q�6L   5m   /   P� 5n   .   $ �@J�IsMouseOver% . . �5o   2   �� $& border��6g    �@ Darken . 6{   �� 5p   2    �@J�RenderTransformOrigin$ 0.5, 0.5&�6Z   �� 5q   2    � z� 5s   6   �� 5t   :   $	 1.2Q�6I   $	 1.2Q�6V   5v   3   5w   /   P� 5x   .   $ �@J�IsKeyboardFocused% . . �5y   2   �� $& border��6g    �@ Darken . 6{   5z   /   P� 5{   .   $ �@ IsIndicatorVisible% . ' 5|   2   �� 5}   6   .��5~   :   �� .��5   >   W� $( 0:0:0.2D�6N   $	) 0.9X�6a   $* 1X�6l   $V+ P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6s   $, ProgressBar��6�   W� 5�   >   $( 0:0:0.2D�6N   $	) 0.9X�6a   $* 1X�6l   $V+ P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6s   $, ProgressBar��6�   5�   ;   5�   7   - 5�   2   �� 5�   6   .��5�   :   �� .��5�   >   W� $( 0:0:0.2D�6N   $) 1X�6a   $	* 0.9X�6j   $V+ P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6s   $, ProgressBar��6�   W� 5�   >   $( 0:0:0.2D�6N   $) 1X�6a   $	* 0.9X�6j   $V+ P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6s   $, ProgressBar��6�   5�   ;   5�   7   5�   /   5�   '   5�      5�      5�      5�      5�      .��5�      � -   5        ��5�   
   �� 5�      . �� 
StartPoint$. 0.1,0&�6"   / �� EndPoint$/ 0.9,1&�65   .��5�      � 0 � Color$0 DarkRed��6   1 � Offset$1 1Q�6/   � 5�      $0 Orange��6   $1 0Q�6.   5�      .+�5�   
   �� $	��340��6   $	��Top=�6   2 �� CornerRadius$2 	0 0 180 0��66   
���   �6O   �� 5�   
   3 �� Orientation$3 
Horizontal=�6   .+�5�      �� .+�5�      �� $
��20 0q�6   .+�5�      �� $��Új felhasználó��6    $��20q�66   
�������4 �� TextAlignment$4 Center=�6U   $��30(�6l   $��
Sitka Text)�6z   �� 5�      -   5        5 ��Name$5 stack1��5�   !   $3 
Horizontal=�61   .+�5�      '  !MaterialDesignThemes.Wpf.PackIcon  6   Kind$
6 User=�62   $��25��6>   $��25��6I   
�������6U   �� 5�      -   5        7 ��Name$7 usernametextbox��5�   "   $
��10 0q�6;   )  #MaterialDesignThemes.Wpf.HintAssist8   Hint$8 Felhasználónév��6I   
�������$��15(�6�   9 �� 
CaretBrush
9 �����: �� SelectionBrush
: �����$	��200��6�   
�������6�   5�      �� 5�      $3 
Horizontal=�6"   $
��0 20q�6;   .+�5�        $6 
Connection=�62   $��25��6D   $��25��6O   
�������6[   �� 5�      -   5        ; ��Name$; userlevelcombo��5�   #   $
��10 0q�6;   $8 Kiválasztás��6I   $��15(�6w   $	��200��6�   
�������6�   5�      �� 5�      $3 
Horizontal=�6!   .+�5�        $
6 Lock=�62   $��25��6?   $��25��6J   
�������6V   G� 5�      -   5        < G�Name$< passwordtextbox��5�   &   $
��10 0q�6?   $8 Jelszó��6M   
�������$��15(�6�   = G� 
CaretBrush
= �����> G� SelectionBrush
> �����$	��200��6�   
�������6�   5�      �� 5�      $3 
Horizontal=�6!   $
��0 20q�6:   .+�5�        $
6 Lock=�62   $��25��6?   $��25��6J   
�������6V   G� 5�      -   5        $< passwordconfirmtextbox��5�   &   $
��10 0q�6F   $8 Jelszó megerősítés��6T   
�������$��15(�6�   
= �����
> �����$	��200��6�   
�������6�   5�      5�      �� 5�      $��10q�6   $��Center=�6)   .+�5�      �� -   5        ? ��Name$? 
confirmbtn��5�      $��Létrehozás��61   $��15(�6F   $	��150��6T   $��40��6`    	 MaterialDesignRaisedButton#��[	 6�   +	  %MaterialDesignThemes.Wpf.ButtonAssist@ 	  CornerRadius$@ 10��5�      $��2q�6G   A �� 	IsDefaultA . 5�      5�      5�      �� 5�      $	��100��6   .+�5�      �� -	   5        $? 
exitbutton��5�      $��10 20q�6-   B � ToolTip$
B Exit��6R   
�������#���   6�   C �� IsCancelC . ��6<   Z� .��5�        $6 Close=�6.   $��30��6;   $��30��6F   
�������6R   5�      5�      5�      5�      5�      