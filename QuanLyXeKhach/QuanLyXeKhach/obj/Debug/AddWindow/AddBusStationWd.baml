   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:QuanLyXeKhach.AddWindowQuanLyXeKhach.AddWindow  5   	   -    'QuanLyXeKhach.AddWindow.AddBusStationWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:QuanLyXeKhach.AddWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��addBusStationWd��5
   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5	   	      addBusStationVM � DataContext# [  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddDriverWd��5   	   $	��400��6   $	��800��6*    � AllowsTransparency . ��66   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�65   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�6*   6:   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � $��0��6   .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông tin bến xe��5'      
�������$��0 20 0 0q�6;   5(      5)      � 5*      $��1��6   	 � ColumnDefinitions	 5+      �� 5,      61   �� 5-      61   .+�5/      � $��0��6    50      �� 51   "   62   �� 52   "   62   .+�54      � $��0��6#   $��
20 20 20 0q�60   .+�55   "   �� .+�56   &   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground

 � � �$��Center=�58   %    �� 	MaxLength$ 6��6@      Hint$ Mã bến xe��59   %    ! MaterialDesignOutlinedTextBox#��[ 5:   %   ��56   B   �� *New.IDBenXe+ �� UpdateSourceTrigger$ PropertyChanged=�.��5:   \   .  (System.Windows.Interactivity.Interaction   Triggers 5;   *   /  )System.Windows.Interactivity.EventTrigger  5<   .      	EventName$ TextChanged��6=   .  (System.Windows.Interactivity.TriggerBase   Actions. 5=   2   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6H   �� *Check+5>   /   .��5?   B   5@   '   �� 5A   &   $��Bottom=�60   
���  ����6\   �� *ErrorMessage+6|   5B   #   5C      � 5D      $��1��6#   $��20q�60   .+�5E   "   �� 
��� � �

 � � �$��Center=�5G      $ Tên Bến Xe��5H      #��[ 5I      ��5E   >   �� *New.TenBenXe+$ PropertyChanged=�5I      5J      5K      � 5L      $��1��6    5M      �� 5N   "   62   �� 5O   "   63   .+�5Q      � $��0��6#   $��20q�60   .+�5R   "   �� 
��� � �

 � � �$��Center=�5T      $ 10��64   $ Số điện thoại��5U      #��[ 5V      ��5R   >   �� *New.SoDienThoaiBen+$ PropertyChanged=�5V      5W      � 5X      $��1��6#   $��20q�60   .+�5Y   "   �� 
��� � �

 � � �$��Center=�5[      $ Địa chỉ��5\      #��[ 5]      ��5Y   >   �� *
New.DiaChi+$ PropertyChanged=�5]      5^      5_      5`      � 5a      $��2��6   	 5b      �� 5c      61   �� 5d      61   .+�5g      � $��0��6   .+�5h      �� $	��120��6%   $
��20 0q�61   $��Thêm��5i      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5j      ��5h   ?   �� *
addCommand+��6^   ��  �� ElementName$ addBusStationWd��5j      5k      � 5m      $��1��6   .+�5n      �� $	��120��6%   $
��20 0q�61   $��Thoát��5o      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5p      ��5n   ?   �� *closeCommand+��6`   �� $ addBusStationWd��5p      5q      5r      5s      5t      5u      5v      5w      