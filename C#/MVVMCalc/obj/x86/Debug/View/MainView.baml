   M S B A M L   `   `   `  ����C  ?MVVMCalc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MVVMCalc.ViewModelMVVMCalc.ViewModel  5   	       MVVMCalc.View.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /vm clr-namespace:MVVMCalc.ViewModel     5   	     � Title$  簡単電卓��5   	   $	��300��5   	    � SizeToContent$ Height=�5   	    J� SnapsToDevicePixels .  � DataContext 5      &    MVVMCalc.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��左辺値：��6   �� 5   
   $��計算方法：��6   $��1��6    �� 5    
   $��	右辺値��6   $��2��6   �� 5#   
   $��1��6Q   ��6   ��  �� Path$	 Lhs� �� UpdateSourceTrigger$ PropertyChanged=�6Q   �� 5&   
    �� SelectedIndex$ 0��6s   $��1��6�   $��1��6�   ��6   �� $ CalculateTypes�	 �� SelectedItem	 6?   �� $ SelectedCalculateType�6�   �� 5'   
   $��2��6Q   $��1��6^   ��6   �� $	 Rhs�$ PropertyChanged=�6^   �� 5(   
   $��計算実行��6   $��3��6J   $��2��6W   ��6    �� $ CalculateCommand�6W   �� 5)   
   $��4��61   $��2��6>   $��Center=�6R   ��6   �� $ Answer�6R   5+      5,      