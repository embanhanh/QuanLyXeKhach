   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:QuanLyXeKhach.AddWindowQuanLyXeKhach.AddWindow  5   	   *    $QuanLyXeKhach.AddWindow.AddCashierWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:QuanLyXeKhach.AddWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��addCashierVM��5	   	     � 
ResizeMode$  NoResize=�5       � WindowStyle$
 None=�5   	      addCashierVM � DataContext# [  5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddDriverWd��5   	   $	��550��6   $	��800��6*    � AllowsTransparency . ��66   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�65   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�6*   6:   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5      �� 5       $
��auto �6(   68   �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � $��0��6   .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông tin thu ngân��5'      
�������$��0 20 0 0q�6=   5(      5)      � 5*      $��1��6   	 � ColumnDefinitions	 5+      �� 5,      61   �� 5-      61   .+�5/      � $��0��6    50      �� 51   "   62   �� 52   "   62   �� 53   "   62   .+�55      � $��0��6#   $��
20 20 20 0q�60   .+�56   "   �� .+�57   &   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground

 � � �$��Center=�59   %      Hint$
 CCCD��5:   %    �� 	MaxLength$ 12��5;   %    ! MaterialDesignOutlinedTextBox#��[ 5<   %   ��57   B   �� *
New.CCCDTN+ �� UpdateSourceTrigger$ PropertyChanged=�.��5<   \   .  (System.Windows.Interactivity.Interaction   Triggers 5=   *   /  )System.Windows.Interactivity.EventTrigger  5>   .      	EventName$ TextChanged��6=   .  (System.Windows.Interactivity.TriggerBase   Actions. 5?   2   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6H   �� *Check+5@   /   .��5A   B   5B   '   �� 5C   &   $��Bottom=�60   
���  ����6\   �� *ErrorMessage+6|   5D   #   5E      � 5F      $��1��6#   $��20q�60   .+�5G   "   �� 
��� � �

 � � �$��Center=�5I      $ 	Họ tên��5J      #��[ 5K      ��5G   >   �� *	New.HoTen+$ PropertyChanged=�5K      5L      � 5M      $��2��6#   $��20q�60   .+�5N   "   �� 
��� � �

 � � �$ Giới tính��5P       " MaterialDesignOutlinedComboBox#��[ 5Q       �� SelectedValue 5N   ?   �� *New.GioiTinh+��5O   F   �� *
GioiTinh+5R   #   5S      5T      � 5U      $��1��6    5V      �� 5W   "   62   �� 5X   "   63   �� 5Y   "   62   .+�5[      � $��0��6#   $��20q�60   .+�5\   "   �� 
��� � �

 � � �$��Center=�5^      $ 10��64   $ Số điện thoại��5_      #��[ 5`      ��5\   >   �� *New.SoDienThoai+$ PropertyChanged=�5`      5a      � 5b      $��1��6#   $��20q�60   .+�5c   "   (  "System.Windows.Controls.DatePicker  
��� � �

 � � �$ 
Ngày sinh��5e       $  MaterialDesignOutlinedDatePicker#��[ 5f         SelectedDate 5c   .   �� *New.NgaySinh+5g   #   5h      � 5i      $��2��6#   $��20q�60   .+�5j   "   �� 
��� � �

 � � �$��Center=�5l      $ Lương��5m      #��[ 5n      ��5j   >   �� *Luong+$ PropertyChanged=�5n      5o      5p      5q      � 5r      $��2��6   $��20q�6(   .+�5s      �� 
��� � �

 � � �$��Center=�5u      $ Địa chỉ��5v      #��[ 5w      ��5s   6   �� *
New.DiaChi+$ PropertyChanged=�5w      5x      � 5y      $��3��6   	 5z      �� 5{      61   �� 5|      61   .+�5      � $��0��6   .+�5�      �� $	��120��6%   $
��20 0q�61   $��Thêm��5�      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   ?   �� *
addCommand+��6^   ��  �� ElementName$ addCashierVM��5�      5�      � 5�      $��1��6   .+�5�      �� $	��120��6%   $
��20 0q�61   $��Thoát��5�      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   ?   �� *closeCommand+��6`   �� $ addCashierVM��5�      5�      5�      5�      5�      5�      5�      5�      