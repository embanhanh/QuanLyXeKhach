   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:QuanLyXeKhach.AddWindowQuanLyXeKhach.AddWindow  5   	   +    %QuanLyXeKhach.AddWindow.AddScheduleWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:QuanLyXeKhach.AddWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��addScheduleWd��5
   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5	   	      addScheduleVM � DataContext# [  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
AddRouteWd��5   	   $	��470��6   $	��800��6)    � AllowsTransparency . ��65   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�6=   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�62   6B   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � $��0��6   .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông tin lịch trình��5'      
�������$��0 20 0 0q�6G   5(      5)      � 5*      $��1��6    5+      �� 5,      6.   �� 5-      6.   �� 5.      6.   .+�50      � $��0��6   $��
20 20 20 0q�6,   .+�51      �� .+�52   "   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist	   
Foreground
	 � � �$	��300��54   !   
 �� 	MaxLength$
 6��6-   $��Center=�55   !      Hint$ Mã lịch trình��56   !    ! MaterialDesignOutlinedTextBox#��[ 57   !   ��52   >   �� *New.IDLICHTRINH+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��57   X   .  (System.Windows.Interactivity.Interaction   Triggers 58   &   /  )System.Windows.Interactivity.EventTrigger  59   *      	EventName$ TextChanged��69   .  (System.Windows.Interactivity.TriggerBase   Actions. 5:   .   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6D   �� *Check+5;   +   .��5<   >   5=   #   �� 5>   "   $��Bottom=�6,   $��Center=�6G   
���  ����6u   �� *ErrorMessage+6�   5?      5@      � 5A      $��1��6    � ColumnDefinitions 5B      �� 5C   "   65   �� 5D   "   65   .+�5F      � $��0��6#   $��20q�63   .+�5G   "   �� 
��� � �
	 � � �$ Biển số xe��5I       " MaterialDesignOutlinedComboBox#��[ 5J       �� SelectedValue 5G   ?   �� *New.BienSoXe+$ PropertyChanged=���5H   J   �� *
BienSoXe+5K   #   5L      � 5M      $��1��6#   $��20q�63   .+�5N   "   �� 
��� � �
	 � � �$ Mã tuyến xe��5P      #��[ 5Q       5N   ?   �� *New.IDTuyenXe+$ PropertyChanged=���5O   J   �� *	IDTuyenXe+5R   #   5S      5T      � 5U      $��2��6    5V      �� 5W   "   65   �� 5X   "   65   .+�5Z      � $��1��6#   $��20q�63   .+�5[   "   �� 
��� � �
	 � � �$	��300��5]   !   $��Center=�5^   !   $ Giá vé��5_   !   #��[ 5`   !   ��5[   >   �� *GiaVe+$ PropertyChanged=�$ TwoWay=�5`   !   5a      � 5b      $��0��6#   $��20q�63   .+�5c   "   (  "System.Windows.Controls.DatePicker  
��� � �
	 � � �$ Ngày xuất phát��5e   !    $  MaterialDesignOutlinedDatePicker#��[ 5f   !      SelectedDate 5c   A   �� *New.NgayXuatPhat+$ PropertyChanged=�5f   !   5g      5h      5i      � 5j      $��2��6    5k      �� 5l      61   �� 5m      61   .+�5o      �� $��0��6!   $	��120��61   $
��20 0q�6=   $��Thêm��5p      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5q      ��5o   K   �� *
addCommand+��6j   ��  �� ElementName$ addScheduleWd��5s      �� 5t      $��1��6!   $	��120��61   $
��20 0q�6=   $��Thoát��5u      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5v      ��5t   K   �� *closeCommand+��6l   �� $ addScheduleWd��5w      5x      5y      5z      5{      5|      5}      