   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QuanLyXeKhach.EditWindowQuanLyXeKhach.EditWindow  5   	   (    "QuanLyXeKhach.EditWindow.EditBusWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:QuanLyXeKhach.EditWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��	editBusWd��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	      	editBusVM � DataContext# [  5
   	    � Title$ 	EditBusVM��5   	   $	��470��6   $	��800��6(    � AllowsTransparency . ��65   Z� .��5      �� ���#44b0f1 �� CornerRadius$ 35��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� ���#0883ff$ 10��6+   $��1q�6>   $��0��6R   $��Center=�5      ���#08a2e1$��Center=�6=   ._�5      � .+�5      �� $��SỬA ĐỔI��6    
�������$��Center=�6B    �� Padding$ 20 10q�6]   $��Center=�5      $��18(�6*   6:   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5      �� 5       $
��auto �6(   68   �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   .+�5$      � .+�5%      �� $��Center=�6$   $��18(�6A   $��Thông tin xe khách��6O   
�������$��0 20 0 0q�6{   5&      5'      � 5(      $��1��6    � ColumnDefinitions 5)      �� 5*      61   �� 5+      61   .+�5-      � $��0��6    5.      �� 5/   "   62   �� 50   "   62   �� 51   "   62   .+�53      � $��0��6#   $��20q�60   .+�54   "   �� ���#44b0f1)  #MaterialDesignThemes.Wpf.HintAssist	   
Foreground	 �#44b0f1$��Center=�56   !   
   Hint$
 Biển số xe��57   !    �� 	MaxLength$ 9��58   !    ! MaterialDesignOutlinedTextBox#��[ 59   !   ��54   @   �� *New.BienSoXe+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�59   !   5:      � 5;      $��1��6#   $��20q�60   .+�5<   "   �� ���#44b0f1	 �#44b0f1$
 	Tài xế��5>   !    " MaterialDesignOutlinedComboBox#��[ 5?   !    �� SelectedValue 5<   A   �� *TaiXe+��5=   P   �� *	ListTaiXe+5@   #   5A      � 5B      $��2��6#   $��20q�60   .+�5C   "   �� ���#44b0f1	 �#44b0f1$��Center=�5E   !   $
 	Loại xe��5F   !   $ 12��5G   !   #��[ 5H   !   ��5C   @   �� *
New.LoaiXe+$ PropertyChanged=�$ TwoWay=�5H   !   5I      5J      � 5K      $��1��6    5L      �� 5M   "   62   �� 5N   "   62   �� 5O   "   62   .+�5Q      � $��0��6#   $��20q�60   .+�5R   "   �� ���#44b0f1	 �#44b0f1$
 Phụ xe��5T   !   #��[ 5U   !    5R   A   �� *PhuXe+��5S   P   �� *	ListPhuXe+5V   #   5W      � 5X      $��1��6#   $��20q�60   .+�5Y   "   �� ���#44b0f1	 �#44b0f1$��Center=�5[   !   $
 
Số Ghế��5\   !   $ 2��5]   !   #��[ 5^   !   ��5Y   @   �� *	New.SoGhe+$ PropertyChanged=�$ TwoWay=�5^   !   5_      � 5`      $��2��6#   $��20q�60   .+�5a   "   �� ���#44b0f1	 �#44b0f1$��Center=�5c   !   $
 Tình trạng��5d   !   $ 50��5e   !   #��[ 5f   !   ��5a   @   �� *New.TinhTrang+$ PropertyChanged=�$ TwoWay=�5f   !   5g      5h      5i      � 5j      $��2��6    5k      �� 5l      61   �� 5m      61   .+�5o      � $��0��6   .+�5p      �� $	��120��6%   $��Sửa��5q      
����������#44b0f1���#44b0f1 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5r      ��5p   1   �� *editCommand+��6Q   ��  �� ElementName$ 	editBusWd��5r      5s      � 5t      $��1��6    .+�5u      �� $	��120��6%   $
��20 0q�61   $��Thoát��5v   !   
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5w   !   ��5u   ?   �� *closeCommand+��6`   �� $ 	editBusWd��5x      5y      5z      5{      5|      5}      5~      5      