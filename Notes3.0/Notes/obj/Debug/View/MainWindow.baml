   M S B A M L   `   `   `  ����@  <Notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NotesNotes  5   	   1clr-namespace:Notes.ViewModelNotes.ViewModel  5   	       Notes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Notes     5   	   ,vmclr-namespace:Notes.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��800��6)    � DataContext 5
        Notes.ViewModel.ViewModel  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $	��10* �6   6+   .+�5   
   ]� 
�������.+�5   
   �� $��5q�5      $��Add Note��5      $��5q�5      ��5      �� *Add+5      �� 5      $��Title��6   $��Center=�5      $��20(�5      $
��Bold"�5      5      �� 5    
   $	��150��5!       �� TextWrapping$
 Wrap=�5"      $��5q�5#      $��5q�5$      ��5       �� *Current.Title+ �� UpdateSourceTrigger$ PropertyChanged=�.��5%      5&      �� 5'      $
��Text��6   $��Center=�5(      $��20(�5)      $
��Bold"�5*      5,      �� 5.      $	��150��5/      $
 Wrap=�50      $��5q�51      $��5q�52      ��5.      �� *Current.TextNote+$ PropertyChanged=�.��52      54      �� 55   
   $��5q�56      $
��Save��57      $��5q�58      $��50��59      ��55      �� *Save+5;      �� 5<   
   $��5q�5=      $��Delete��5>      $��5q�5?      $��50��5@      $
��Left=�5A      ��5<      �� *Remove+5C      5E      �� 5F      -   5        $��listBoxNotes��5G      $��1��5F      $��Disabled=�5J      
���������5H      �� *Notes+ �� SelectedItem 5I      �� *	Current+��5M      �� 5N      .R�5O      �� .+�5P      �� $��3q�6!   $��5q�5Q   !   
���   � �� CornerRadius$ 5��5S   !   ._�5T      �  5U      �� 5V   "   62   �� 5W   "   62   .+�5Z      �� $��20(�6$   
�������
���   �$��5q�5]   $    �� Padding$ 5q�5^   $   �� 5_      $��20(�5`   "   $
��Bold"�5a   "   �5_   "   �� *Title+5a   6    �� 5b      $� ��6"   6-    �� 5c      $��16(�5d   "   �5c   "   �� *
TextNote+5e   %   5f      �� 5g      $��1��6$   $��Uniform=�5h       $	��200��5i       $	��100��5j       $��5q�5k       ��5l       �� *Image+5n      5p      5q      5s      5t      ��5v      �� 5w      .R�5x      � 6"   5y      5{      5|      5}      