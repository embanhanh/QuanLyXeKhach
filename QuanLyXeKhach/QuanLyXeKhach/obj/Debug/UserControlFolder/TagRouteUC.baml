   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5      0    *QuanLyXeKhach.UserControlFolder.TagRouteUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:QuanLyXeKhach.UserControlFolder     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��
ucTagRoute��5      $��5q�5
       
  MainVM  � DataContext#  [  6)    J� Opacity$	 0.8Q�5   5   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ 	MouseDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     CommandParameter 6$   ��  �� ElementName$ 
ucTagRoute��   Command 6X   �� *SelectTagRoute+5        5   
   $ GotFocus��6   . 5         6$   �� $ 
ucTagRoute�� 6X   �� *SelectTagRoute+5      .��5      �� ���#C1F2B0 �� CornerRadius$ 15��6$   $��1q�66   
�������._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��0.7* �6#   62   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��0.65* �6#   63   .+�5       � $��0��6   .+�5!      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 BusSide=�6*   $��80��5"      $��80��6!   $��Center=�6,   5#      � 5$      $��1��6   .+�5%      �� -   5         ��Name$ BenXeXP��5'   -   $��2q�5%      
���   � �� TextAlignment$ Center=�69   )  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 �   �$��Center=�5'         
Background �#C1F2B0   Hint$ Bến Xe Xuất Phát��5)       �� 
IsReadOnly . $	��1.5q�5*   '    ! MaterialDesignOutlinedTextBox#��[ 5+      $��8q�5,      5-      � 5.      $��2��6   .+�5/      �� -   5        $ BenXeDD��55      $��2q�5/      
���   �
 �   �$��Center=�51       . $	��1.5q�52   $    �#C1F2B0$ Bến Xe Đích Đến��54      $ Center=�55   #   #��[ 56      $��8q�57      58      � 59      $��3��6   .+�5:      �� -   5        $ GioXP��5?      $��2q�5:      
���   �$	��1.5q�5;      
 �   �$ Giờ Xuất Phát��5=       �#C1F2B0$ Center=�5?        . $��Center=�5A      #��[ 5B      $��8q�5C      5E      � 5F      $��4��6   .+�5G      �� -   5        $ GioDD��5L      $��2q�5G      
���   �
 �   �$��Center=�5I       �#C1F2B0$ Thời Gian Dự Kiến��5K      $	��1.5q�5L   !    . $ Center=�5M   $   #��[ 5N      $��8q�5O      5P      � 5Q      $��5��6   .+�5R      �� -   5        $ 	IDTuyenXe��5W      $��10q�5R      
���   �$	��1.5q�5S      
 �   �$ ID��5U       �#C1F2B0$ Center=�5W   )    . $��80��5X   '   $��Center=�5Y      #��[ 5Z      $��8q�5[      5\      5]      5^      5_      