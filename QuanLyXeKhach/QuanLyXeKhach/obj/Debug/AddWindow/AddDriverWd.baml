   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyXeKhachQuanLyXeKhach  5   	       QuanLyXeKhach.AddDriverWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyXeKhach     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��addDriverWd��5
   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5	   	      addDriverVM � DataContext# [  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddDriverWd��5   	   $	��570��6   $	��800��6*    � AllowsTransparency . ��66   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�6=   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�62   6B   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   �� 5$      $
��auto �6(   68   .+�5&      � $��0��6   .+�5'      �� $��Center=�6$   $��18(�6A   $��Thông tin tài xế��5(      
�������$��0 20 0 0q�6C   5)      5*      � 5+      $��1��6   	 � ColumnDefinitions	 5,      �� 5-      61   �� 5.      61   .+�50      � $��0��6    51      �� 52   "   62   �� 53   "   62   �� 54   "   62   .+�56      � $��0��6#   $��
20 20 20 0q�60   .+�57   "   �� .+�58   &   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground

 � � �$	��Top=�5:   %      Hint$
 CCCD��5;   %    �� 	MaxLength$ 12��5<   %    ! MaterialDesignOutlinedTextBox#��[ 5=   %   ��58   B   �� *
New.CCCDTX+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��5=   \   .  (System.Windows.Interactivity.Interaction   Triggers 5>   *   /  )System.Windows.Interactivity.EventTrigger  5?   .      	EventName$ TextChanged��6=   .  (System.Windows.Interactivity.TriggerBase   Actions. 5@   2   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6H   �� *Check+5A   /   .��5B   B   5C   '   �� 5D   &   $��Bottom=�60   
���  ����6\   �� *ErrorMessage+6|   5E   #   5F      � 5G      $��1��6#   $��20q�60   .+�5H   "   �� 
��� � �

 � � �$��Center=�5J   !   $ 	Họ tên��5K   !   #��[ 5L   !   ��5H   >   �� *New.TenTaiXe+$ PropertyChanged=�$ TwoWay=�5L   !   5M      � 5N      $��2��6#   $��20q�60   .+�5O   "   �� 
��� � �

 � � �$ Bằng lái��5Q   !    " MaterialDesignOutlinedComboBox#��[ 5R   !    �� SelectedValue 5O   ?   �� *New.BangLai+$ PropertyChanged=���5P   N   �� *	BangLai+5S   #   5T      5U      � 5V      $��1��6    5W      �� 5X   "   62   �� 5Y   "   63   �� 5Z   "   62   .+�5\      � $��0��6#   $��20q�60   .+�5]   "   �� 
��� � �

 � � �$��Center=�5_   !   $ 10��6<   $ Số điện thoại��5`   !   #��[ 5a   !   ��5]   >   �� *New.SoDienThoai+$ PropertyChanged=�5a   !   5b      � 5c      $��1��6#   $��20q�60   .+�5d   "   (  "System.Windows.Controls.DatePicker  
��� � �

 � � �$ 
Ngày sinh��5f   !    $  MaterialDesignOutlinedDatePicker#��[ 5g   !      SelectedDate 5d   .   �� *New.NgaySinh+$ PropertyChanged=�5h   #   5i      � 5j      $��2��6#   $��20q�60   .+�5k   "   �� 
��� � �

 � � �$��Center=�5m   !   $ Lương��5n   !   #��[ 5o   !   ��5k   >   �� *Luong+$ PropertyChanged=�5o   !   5p      5q      5r      � 5s      $��2��6   $��20q�6(   .+�5t      �� 
��� � �

 � � �$��Center=�5v      $ Địa chỉ��5w      #��[ 5x      ��5t   6   �� *
New.DiaChi+$ PropertyChanged=�5x      5y      � 5z      $��3��6   	 5{      �� 5|      61   �� 5}      61   .+�5�      � $��0��6   .+�5�      �� $	��120��6%   $
��20 0q�61   $��Thêm��5�      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   ?   �� *
addCommand+��6^   ��  �� ElementName$ addDriverWd��5�      5�      � 5�      $��1��6   .+�5�      �� $	��120��6%   $
��20 0q�61   $��Thoát��5�      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   ?   �� *closeCommand+��6`   �� $ addDriverWd��5�      5�      5�      5�      5�      5�      5�      5�      