   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QuanLyXeKhach.EditWindowQuanLyXeKhach.EditWindow  5   	   ,    &QuanLyXeKhach.EditWindow.EditCashierWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:QuanLyXeKhach.EditWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��editCashierWd��5   	     � WindowStartupLocation$  CenterScreen=�5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5	   	      editCashierVM � DataContext# [  5
   	    � Title$ EditDriverWd��5   	   $	��550��6   $	��800��6+    � AllowsTransparency . ��67   Z� .��5      �� ���#44b0f1 �� CornerRadius$ 35��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� ���#0883ff$ 10��6+   $��1q�6>   $��0��6R   $��Center=�5      ���#08a2e1$��Center=�6=   ._�5      � .+�5      �� $��SỬA ĐỔI��6    
�������$��Center=�6B    �� Padding$ 20 10q�6]   $��Center=�5   	   $��18(�6&   66   5      5      �� 5      
�������$��30 10 30 30q�6(   $ 35��6=   $��1��6O   ._�5      �  5      �� 5       $
��auto �6(   68   �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � $��0��6   .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông tin thu ngân��5'      
�������$��0 20 0 0q�6E   5(      5)      � 5*      $��1��6   	 � ColumnDefinitions	 5+      �� 5,      61   �� 5-      61   .+�5/      � $��0��6    50      �� 51   "   62   �� 52   "   62   �� 53   "   62   .+�55      � $��0��6#   $��20q�60   .+�56   "   �� ���#44b0f1)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground
 �#44b0f1$��Center=�58   !      Hint$
 CCCD��59   !    �� 	MaxLength$ 12��5:   !    ! MaterialDesignOutlinedTextBox#��[ 5;   !   ��56   @   �� *
New.CCCDTN+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5;   !   5<      � 5=      $��1��6#   $��20q�60   .+�5>   "   �� ���#44b0f1
 �#44b0f1$��Center=�5@      $ 	Họ tên��5A      #��[ 5B      ��5>   @   �� *	New.HoTen+$ PropertyChanged=�$ TwoWay=�5B      5C      � 5D      $��2��6#   $��20q�60   .+�5E   "   �� ���#44b0f1
 �#44b0f1$ Giới tính��5G       " MaterialDesignOutlinedComboBox#��[ 5H       �� SelectedValue 5E   A   �� *New.GioiTinh+��5F   @   �� *
GioiTinh+5I   #   5J      5K      � 5L      $��1��6    5M      �� 5N   "   62   �� 5O   "   63   �� 5P   "   62   .+�5R      � $��0��6#   $��20q�60   .+�5S   "   �� ���#44b0f1
 �#44b0f1$��Center=�5U      $ 10��6,   $ Số điện thoại��5V      #��[ 5W      ��5S   @   �� *New.SoDienThoai+5W      5X      � 5Y      $��1��6#   $��20q�60   .+�5Z   "   (  "System.Windows.Controls.DatePicker  ���#44b0f1
 �#44b0f1$ 
Ngày sinh��5\       $  MaterialDesignOutlinedDatePicker#��[ 5]         SelectedDate 5Z   C   �� *New.NgaySinh+5]      5^      � 5_      $��2��6#   $��20q�60   .+�5`   "   �� ���#44b0f1
 �#44b0f1$��Center=�5b      $ Lương��5c      #��[ 5d      ��5`   @   �� *Luong+5d      5e      5f      5g      � 5h      $��2��6   $��20q�6(   .+�5i      �� ���#44b0f1
 �#44b0f1$��Center=�5k      $ Địa chỉ��5l      #��[ 5m      ��5i   8   �� *
New.DiaChi+5m      5n      � 5o      $��3��6   	 5p      �� 5q      62   �� 5r      62   .+�5u      � $��0��6   .+�5v      �� $	��120��6%   $��Sửa��5w      
����������#44b0f1���#44b0f1 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5x      ��5v   1   �� *editCommand+��6Q   ��  �� ElementName$ editCashierWd��5x      5y      � 5{      $��1��6   .+�5|      �� $	��120��6%   $
��20 0q�61   $��Thoát��5}      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5~      ��5|   ?   �� *closeCommand+��6`   �� $ editCashierWd��5~      5      5�      5�      5�      5�      5�      5�      