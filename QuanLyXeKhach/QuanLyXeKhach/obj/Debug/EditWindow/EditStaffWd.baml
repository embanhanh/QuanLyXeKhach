   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QuanLyXeKhach.EditWindowQuanLyXeKhach.EditWindow  5   	   *    $QuanLyXeKhach.EditWindow.EditStaffWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:QuanLyXeKhach.EditWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��editStaffWd��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5
   	      editStaffVM � DataContext# [  5   	    � Title$ EditDriverWd��5   	   $	��550��6   $	��800��6+    � AllowsTransparency . ��67   Z� .��5      �� ���#44b0f1 �� CornerRadius$ 35��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� ���#0883ff$ 10��6+   $��1q�6>   $��0��6R   $��Center=�5      ���#08a2e1$��Center=�65   ._�5      � .+�5      �� $��SỬA ĐỔI��6    
�������$��Center=�6B    �� Padding$ 20 10q�6]   $��Center=�5      $��18(�6*   6:   5      5      �� 5      
�������$��30 10 30 30q�6(   $ 35��6=   $��1��6O   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   �� 5$      $
��auto �6(   68   .+�5&      � $��0��6   .+�5'      �� $��Center=�6$   $��18(�6A   $��Thông tin phụ xe��5(      
�������$��0 20 0 0q�67   5)      5*      � 5+      $��1��6   	 � ColumnDefinitions	 5,      �� 5-      61   �� 5.      61   .+�50      � $��0��6    51      �� 52   "   62   �� 53   "   62   �� 54   "   62   .+�56      � $��0��6#   $��20q�60   .+�57   "   �� ���#44b0f1)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground
 �#44b0f1$��Center=�59         Hint$
 CCCD��5:       �� 	MaxLength$ 12��5;       ! MaterialDesignOutlinedTextBox#��[ 5<      ��57   @   �� *
New.CCCDNV+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5<      5=      � 5>      $��1��6#   $��20q�60   .+�5?   "   �� ���#44b0f1
 �#44b0f1$��Center=�5A      $ 	Họ tên��5B      #��[ 5C      ��5?   @   �� *New.HoTenNhanVien+$ PropertyChanged=�$ TwoWay=�5C      5D      � 5E      $��2��6#   $��20q�60   .+�5F   "   �� ���#44b0f1
 �#44b0f1$ Giới tính��5H       " MaterialDesignOutlinedComboBox#��[ 5I       �� SelectedValue 5F   A   �� *New.GioiTinh+��5G   D   �� *
GioiTinh+5J   #   5K      5L      � 5M      $��1��6    5N      �� 5O   "   62   �� 5P   "   63   �� 5Q   "   62   .+�5S      � $��0��6#   $��20q�60   .+�5T   "   �� ���#44b0f1
 �#44b0f1$��Center=�5V      $ 10��60   $ Số điện thoại��5W      #��[ 5X      ��5T   @   �� *New.SoDienThoai+5X      5Y      � 5Z      $��1��6#   $��20q�60   .+�5[   "   (  "System.Windows.Controls.DatePicker  ���#44b0f1
 �#44b0f1$ 
Ngày sinh��5]       $  MaterialDesignOutlinedDatePicker#��[ 5^         SelectedDate 5[   C   �� *New.NgaySinh+5^      5_      � 5`      $��2��6#   $��20q�60   .+�5a   "   �� ���#44b0f1
 �#44b0f1$��Center=�5c   !   $ Lương��5d   !   #��[ 5e   !   ��5a   @   �� *Luong+5e   !   5f      5g      5h      � 5i      $��2��6   $��20q�6(   .+�5j      �� ���#44b0f1
 �#44b0f1$��Center=�5l      $ Địa chỉ��5m      #��[ 5n      ��5j   8   �� *
New.DiaChi+5n      5o      � 5p      $��3��6   	 5q      �� 5r      62   �� 5s      62   .+�5v      � $��0��6   .+�5w      �� $	��120��6%   $��Sửa��5x      
����������#44b0f1���#44b0f1 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5y      ��5w   1   �� *editCommand+��6Q   ��  �� ElementName$ editStaffWd��5y      5z      � 5|      $��1��6   .+�5}      �� $	��120��6%   $
��20 0q�61   $��Thoát��5~      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5      ��5}   ?   �� *closeCommand+��6`   �� $ editStaffWd��5      5�      5�      5�      5�      5�      5�      5�      