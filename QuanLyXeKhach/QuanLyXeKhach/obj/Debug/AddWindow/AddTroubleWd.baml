   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:QuanLyXeKhach.AddWindowQuanLyXeKhach.AddWindow  5   	   *    $QuanLyXeKhach.AddWindow.AddTroubleWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:QuanLyXeKhach.AddWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��addTroubleWd��5   
     � 
ResizeMode$  NoResize=�5	   
    � WindowStyle$
 None=�5
   
      addTroubleVM � DataContext# [  5   
    � WindowStartupLocation$ CenterScreen=�5   
    � Title$ AddTroubleWd��5   	   $	��460��6   $	��800��6+    � AllowsTransparency . ��67   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�6=   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�62   6B   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5      �� 5       $
��auto �6(   68   �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   .+�5$      � .+�5%      �� $��Center=�6$   $��18(�6A   $��Thông tin tài khoản��6O   
�������$��0 20 0 0q�6|   5&      5'      � 5(      $��1��6   	 � ColumnDefinitions	 5)      �� 5*      61   �� 5+      61   .+�5-      � $��0��6    5.      �� 5/   "   62   �� 50   "   62   �� 51   "   62   .+�53      � $��0��6#   $�� 20 20 20 0q�60   .+�54   "   �� .+�55   &   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground

 � � �$��Center=�57   %      Hint$ Mã sự cố��58   %    �� 	MaxLength$ 6��59   %    ! MaterialDesignOutlinedTextBox#��[ 5:   %   ��55   B   �� *
New.IDsuco+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��5:   \   .  (System.Windows.Interactivity.Interaction   Triggers 5;   *   /  )System.Windows.Interactivity.EventTrigger  5<   .      	EventName$ TextChanged��6=   .  (System.Windows.Interactivity.TriggerBase   Actions. 5=   2   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6H   �� *Check+5>   /   .��5?   B   5@   '   �� 5A   &   $��Bottom=�60   
���  ����6\   �� *ErrorMessage+6|   5B   #   5C      � 5D      $��1��6#   $��20q�60   .+�5E   "   �� 
��� � �

 � � �$��Center=�5G      $ Tên sự cố��5H      #��[ 5I      ��5E   >   �� *New.TenSuCo+$ PropertyChanged=�$ TwoWay=�5I   R   5J      � 5K      $��2��6#   $��20q�60   .+�5L   "   �� 
��� � �

 � � �$��Center=�5N      $ Chi phí��5O      #��[ 5P      ��5L   >   �� *
New.ChiPhi+$ PropertyChanged=�$ TwoWay=�5P   R   5Q      5R      � 5S      $��1��6    5T      �� 5U   "   62   �� 5V   "   62   �� 5W   "   62   .+�5Y      � $��0��6#   $��20q�60   .+�5Z   "   �� 
��� � �

 � � �$ Biển số xe��5\   %    " MaterialDesignOutlinedComboBox#��[ 5]   %    �� SelectedValue 5Z   ?   �� *New.BienSoXe+$ PropertyChanged=�$ TwoWay=���5[   R   �� *Li_BienSoXe+5^   #   5_      � 5`      $��1��6#   $��20q�60   .+�5a   "   �� 
��� � �

 � � �$ Tình trạng��5c      #��[ 5d       5a   ?   �� *New.TinhTrang+$ PropertyChanged=�$ TwoWay=���5b   J   �� *Li_TinhTrang+5e   #   5f      � 5g      $��2��6#   $��20q�60   .+�5h   "   (  "System.Windows.Controls.DatePicker  
��� � �

 � � �$ Ngày xảy ra��5j       $  MaterialDesignOutlinedDatePicker#��[ 5k         SelectedDate 5h   .   �� *New.NgayGapSuCo+$ PropertyChanged=�5l   #   5m      5n      5o      � 5p      $��2��6   	 5q      �� 5r      61   �� 5s      61   .+�5u      �� $��0��6!   $	��120��61   $
��20 0q�6=   $��Thêm��5v      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5w      ��5u   K   �� *
addCommand+��6j   ��  �� ElementName$ addTroubleWd��5y      �� 5z      $��1��6!   $	��120��61   $
��20 0q�6=   $��Thoát��5{      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5|      ��5z   K   �� *closeCommand+��6l   �� $ addTroubleWd��5~      5      5�      5�      5�      5�      5�      