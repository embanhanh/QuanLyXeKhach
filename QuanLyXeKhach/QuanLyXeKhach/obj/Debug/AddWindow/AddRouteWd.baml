   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyXeKhachQuanLyXeKhach  5   	       QuanLyXeKhach.AddRouteWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyXeKhach     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
addRouteWd��5
   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5	   	      
addRouteVM � DataContext# [  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
AddRouteWd��5   	   $	��470��6   $	��800��6)    � AllowsTransparency . ��65   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�6A   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�6*   6:   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � $��0��6   .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông tin tuyến xe��5'      
�������$��0 20 0 0q�6=   5(      5)      � 5*      $��1��6    5+      �� 5,      6.   �� 5-      6.   �� 5.      6.   .+�50      � $��0��6   $��
20 20 20 0q�6,   .+�51      �� .+�52   "   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist	   
Foreground
	 � � �$	��300��54   %   $	��Top=�55   %   
   Hint$
 Mã Tuyến Xe��56   %    �� 	MaxLength$ 6��57   %    ! MaterialDesignOutlinedTextBox#��[ 58   %   ��52   >   �� *New.IDTuyenXe+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��58   \   .  (System.Windows.Interactivity.Interaction   Triggers 59   &   /  )System.Windows.Interactivity.EventTrigger  5:   *      	EventName$ TextChanged��69   .  (System.Windows.Interactivity.TriggerBase   Actions. 5;   .   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6D   �� *Check+5<   +   .��5=   >   5>   #   �� 5?   "   $��Bottom=�6,   $��Center=�6G   
���  ����6u   �� *ErrorMessage+6�   5@      5A      � 5B      $��1��6    � ColumnDefinitions 5C      �� 5D   "   65   �� 5E   "   65   .+�5G      � $��0��6#   $��20q�63   .+�5H   "   �� 
��� � �
	 � � �$
 Bến Xe Xuất Phát��5J   !    " MaterialDesignOutlinedComboBox#��[ 5K   !    �� SelectedValue 5H   ?   �� *	BenXeXP+$ PropertyChanged=���5I   N   �� *BenXe+5L   #   5M      � 5N      $��1��6#   $��20q�63   .+�5O   "   �� 
��� � �
	 � � �$
 Bến Xe Đích Đến��5Q   !   #��[ 5R   !    5O   ?   �� *	BenXeDD+$ PropertyChanged=���5P   N   �� *BenXe+5S   #   5T      5U      � 5V      $��2��6    5W      �� 5X   "   65   �� 5Y   "   65   .+�5[      � $��1��6#   $��20q�63   .+�5\   "   )  #MaterialDesignThemes.Wpf.TimePicker  
��� � �$
 Thời gian dự kiến��5_   #      	Is24Hours .  $  MaterialDesignOutlinedTimePicker#��[ 5a   #      SelectedTime 5]   #   �� *GioDD+$ PropertyChanged=�5a   #   5b      � 5c      $��0��6#   $��20q�63   .+�5d   "     
��� � �$
 Giờ Xuất Phát��5g   #    . #��[ 5i   #    5e   #   �� *GioXP+$ PropertyChanged=�5i   #   5j      5k      5l      � 5m      $��2��6    5n      �� 5o      61   �� 5p      61   .+�5r      �� $��0��6!   $	��120��61   $
��20 0q�6=   $��Thêm��5s      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5t      ��5r   K   �� *
addCommand+��6j   ��  �� ElementName$ 
addRouteWd��5v      �� 5w      $��1��6!   $	��120��61   $
��20 0q�6=   $��Thoát��5x   	   
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5y   	   ��5w   K   �� *closeCommand+��6l   �� $ 
addRouteWd��5{      5|      5}      5~      5      5�      5�      