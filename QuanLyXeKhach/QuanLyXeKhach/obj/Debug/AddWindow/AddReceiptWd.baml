   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:QuanLyXeKhach.AddWindowQuanLyXeKhach.AddWindow  5   	   *    $QuanLyXeKhach.AddWindow.AddReceiptWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:QuanLyXeKhach.AddWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��addReceiptWd��5	   	     � 
ResizeMode$  NoResize=�5       � WindowStyle$
 None=�5   	      addReceiptVM � DataContext# [  5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddReceiptWd��5   	   $	��730��6   $	��800��6+    � AllowsTransparency . ��67   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5      ���#25b24a$��Center=�6=   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5      $��18(�62   6B   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � $��0��6   .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông Tin Biên Lai��5'      
�������$��0 20 0 0q�6E   5(      5)      � 5*      $��1��6    5+      �� 5,      6.   �� 5-      6.   �� 5.      6.   �� 5/      6.   �� 50      6.   �� 51      6.   .+�53      � $��0��6   $��0 20 0 0q�6,   	 � ColumnDefinitions	 54      �� 55   "   65   �� 56   "   65   .+�58      � $��0��6#   $��	20 0 20 0q�63   .+�59   "   �� .+�5:   &   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground

 � � �$��Center=�5<   %      Hint$ Mã Biên Lai��5=   %    �� 	MaxLength$ 6��5>   %    ! MaterialDesignOutlinedTextBox#��[ 5?   %   ��5:   B   �� *New.IDBienLai+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��5?   \   .  (System.Windows.Interactivity.Interaction   Triggers 5@   *   /  )System.Windows.Interactivity.EventTrigger  5A   .      	EventName$ TextChanged��6=   .  (System.Windows.Interactivity.TriggerBase   Actions. 5B   2   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6H   �� *Check+5C   /   .��5D   B   5E   '   �� 5F   &   $��Bottom=�60   
���  ����6\   �� *ErrorMessage+6|   5G   #   5H      � 5I      $��2��6#   $��
20 0 20 20q�63   .+�5J   "   �� -   5         ��Name$ 	LichTrinh��5L   M   
��� � �

 � � �$ Lịch Trình��6!    " MaterialDesignOutlinedComboBox#��[ 5M   !    �� SelectedValue 5J   ?   �� *IDLichTrinh+$ PropertyChanged=���5K   N   �� *
LLichTrinh+ 5N   &     5O   *   $ SelectionChanged��69   . 5P   .        CommandParameter 6D   ��  �� ElementName$ 	LichTrinh�� 6w   �� *Show+5Q   +   5S   #   5T      5U      � 5V      $��1��6   	 5W      �� 5X   "   65   �� 5Y   "   65   .+�5[      � $��0��6#   $��20q�63   	 5\   "   �� 5]   &   $	��38* �67   �� 5^   &   $��3* �67   .+�5`   "   �� 
��� � �

 � � �$��Center=�5b   !   $ Tên Hành Khách��5c   !   #��[ 5d   !   $��2��6X   ��5`   >   �� *New.TenHanhKhach+$ PropertyChanged=�$ TwoWay=�5d   X   5e      � 5f      $��1��6#   $��20q�63   .+�5g   "   �� 
��� � �

 � � �$��Center=�5i   !    �� 
IsReadOnly . $ Bến Xuất Phát��5j   !   #��[ 5k   !   ��5g   >   �� *BenDau+$ PropertyChanged=�$ TwoWay=�5k   !   5m      5n      � 5o      $��2��6   	 5p      �� 5q   "   65   �� 5r   "   65   .+�5t      � $��0��6#   $��20q�63   	 5u   "   �� 5v   &   $	��38* �67   �� 5w   &   $��3* �67   .+�5y   "   �� 
��� � �

 � � �$��Center=�5{   !   $ 10��6=   $ Số Điện Thoại��5|   !   #��[ 5}   !   $��2��6X   ��5y   >   �� *New.SoDienThoaiHK+$ PropertyChanged=�$ TwoWay=�5}   X   5~      � 5      $��1��6#   $��20q�63   .+�5�   "   �� 
��� � �

 � � �$��Center=�5�   !    . $ Bến Đích Đến��5�   !   #��[ 5�   !   ��5�   >   �� *	BenCuoi+$ PropertyChanged=�$ TwoWay=�5�   !   5�      5�      � 5�      $��3��6   	 5�      �� 5�   "   65   �� 5�   "   65   .+�5�      � $��0��6#   $��20q�63   	 5�   "   �� 5�   &   $	��38* �67   �� 5�   &   $��3* �67   .+�5�   "   (  "System.Windows.Controls.DatePicker  
��� � �

 � � �$ 	Ngày Mua��5�   !    $  MaterialDesignOutlinedDatePicker#��[ 5�   !   $��2��6[      SelectedDate 5�   .   �� *New.NgayMua+$ PropertyChanged=�5�   #   5�      � 5�      $��1��6#   $��20q�63   .+�5�   "   �� 
��� � �

 � � �$ Ghế��5�   "   #��[ 5�   "    5�   ?   �� *	New.IDGhe+$ PropertyChanged=�$ TwoWay=���5�   O   �� *LGhe+$ TwoWay=�$ PropertyChanged=�5�   #   5�      5�      � 5�      $��4��6   	 5�      �� 5�   "   65   �� 5�   "   65   .+�5�      � $��0��6#   $��20q�63   .+�5�   "   �� 
��� � �

 � � �$��Center=�5�   "    . $ Giá Vé��5�   "   #��[ 5�   "   ��5�   >   �� *GiaVe+$ PropertyChanged=�$ TwoWay=�5�   "   5�      � 5�      $��1��6#   $��20q�63   .+�5�   "   �� 
��� � �

 � � �$ 	Thu Ngân��5�   %   #��[ 5�   %    5�   ?   �� *	ThuNgan+$ PropertyChanged=���5�   R   �� *
LThuNgan+5�   #   5�      5�      � 5�      $��5��6   	 5�      �� 5�   "   65   �� 5�   "   65   .+�5�      � $��0��6#   $��	20 0 20 0q�63   .+�5�   "   �� 
��� � �

 � � �$��Center=�5�   %    . $ Thời Gian Xuất Phát��5�   %   #��[ 5�   %   ��5�   >   �� *ThoiGianXuatPhat+$ PropertyChanged=�$ TwoWay=�5�   %   5�      � 5�      $��1��6#   $��20q�63   .+�5�   "   �� -   5        $��GGiamGia��5�   O   
��� � �

 � � �$ Giảm Giá��6%   #��[ 5�   %    5�   ?   �� *New.GiamGia+$ PropertyChanged=���5�   R   �� *
LGiamGia+ 5�   &     5�   *   $ SelectionChanged��69   . 5�   .      6D   �� $ GGiamGia�� 6v   �� *GGia+5�   +   5�   #   5�      5�      5�      � 5�      $��2��6   	 5�      �� 5�      61   �� 5�      61   .+�5�      �� $��0��6!   $	��120��61   $
��20 0q�6=   $��Thêm��5�      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   K   �� *
addCommand+��6j   �� $ addReceiptWd��5�      �� 5�      $��1��6!   $	��120��61   $
��20 0q�6=   $��Thoát��5�      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   K   �� *closeCommand+��6l   �� $ addReceiptWd��5�      5�      5�      5�      5�      5�      5�      