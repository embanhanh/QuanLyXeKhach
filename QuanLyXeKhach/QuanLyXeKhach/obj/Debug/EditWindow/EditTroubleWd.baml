   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QuanLyXeKhach.EditWindowQuanLyXeKhach.EditWindow  5   	   ,    &QuanLyXeKhach.EditWindow.EditTroubleWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:QuanLyXeKhach.EditWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��editTroubleWd��5   
     � 
ResizeMode$  NoResize=�5	   
    � WindowStyle$
 None=�5
   
      editTroubleVM � DataContext# [  5   
    � WindowStartupLocation$ CenterScreen=�5   
    � Title$ EditTroubleWd��5   	   $	��460��6   $	��800��6,    � AllowsTransparency . ��68   Z� .��5      �� ���#44b0f1 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  J� RenderTransformOrigin$ 0.184,1.314&�6    � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� ���#0883ff$ 10��6+   $��2q�6>   $��0��6R   $��Center=�5      ���#08a2e1$��Center=�6=   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C   	 �� Padding$	 20 10q�6^   $��Center=�5      $��18(�6*   6:   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5      �� 5       $
��auto �6(   68   �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   .+�5$      � .+�5%      �� $��Center=�6$   $��18(�6A   $��Thông tin tài khoản��6O   
�������$��0 20 0 0q�6|   5&      5'      � 5(      $��1��6   
 � ColumnDefinitions
 5)      �� 5*      61   �� 5+      61   .+�5-      � $��0��6    5.      �� 5/   "   62   �� 50   "   62   �� 51   "   62   .+�53      � $��0��6#   $
�� 20 q�60   .+�54   "   �� ���#44b0f1)  #MaterialDesignThemes.Wpf.HintAssist   
Foreground �#44b0f1$��Center=�56       �� 
IsReadOnly .    Hint$ Mã sự cố��57       ! MaterialDesignOutlinedTextBox#��[ 58      ��54   @   �� *
New.IDsuco+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�58   V   59      � 5:      $��1��6#   $��20q�60   .+�5;   "   �� ���#44b0f1 �#44b0f1$��Center=�5=       . $ Tên sự cố��5>      #��[ 5?      ��5;   @   �� *New.TenSuCo+$ PropertyChanged=�$ TwoWay=�5?   V   5@      � 5A      $��2��6#   $��20q�60   .+�5B   "   �� ���#44b0f1 �#44b0f1$��Center=�5D       . $ Chi phí��5E      #��[ 5F      ��5B   @   �� *
New.ChiPhi+$ PropertyChanged=�$ TwoWay=�5F   V   5G      5H      � 5I      $��1��6    5J      �� 5K   "   62   �� 5L   "   62   �� 5M   "   62   .+�5O      � $��0��6#   $��20q�60   .+�5P   "   �� ���#44b0f1 �#44b0f1$��Center=�5R   !    . $ Biển số xe��5S   !   #��[ 5T   !   ��5P   @   �� *New.BienSoXe+$ PropertyChanged=�$ TwoWay=�5T   Z   5U      � 5V      $��1��6#   $��20q�60   .+�5W   "   �� ���#44b0f1 �#44b0f1$ Tình trạng��5Y   !    " MaterialDesignOutlinedComboBox#��[ 5Z   !    �� SelectedValue 5W   A   �� *New.TinhTrang+$ PropertyChanged=�$ TwoWay=���5X   P   �� *Li_TinhTrang+5[   #   5\      � 5]      $��2��6#   $��20q�60   .+�5^   "   �� ���#44b0f1 �#44b0f1$��Center=�5`   !    . $ Ngày xảy ra��5a   !   #��[ 5b   !   ��5^   @   �� *	NgayXayRa+$ PropertyChanged=�$ TwoWay=�5b   Z   5c      5d      5e      � 5f      $��2��6   
 5g      �� 5h      61   �� 5i      61   .+�5k      �� $��0��6!   $	��120��61   $
��20 0q�6=   $��Sửa��5l      
����������#44b0f1���#44b0f1 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5m      ��5k   K   �� *editCommand+��6k   ��  �� ElementName$ editTroubleWd��5o      �� 5p      $��1��6!   $	��120��61   $
��20 0q�6=   $��Thoát��5q      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5r      ��5p   K   �� *closeCommand+��6l   �� $ editTroubleWd��5t      5u      5v      5w      5x      5y      5z      