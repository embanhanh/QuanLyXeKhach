   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:QuanLyXeKhach.AddWindowQuanLyXeKhach.AddWindow  5   	   *    $QuanLyXeKhach.AddWindow.AddAccountWd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:QuanLyXeKhach.AddWindow     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5        $��addAccountWd��5   
     � 
ResizeMode$  NoResize=�5
   
    � WindowStyle$
 None=�5   
      addAccountVM � DataContext# [  5   
    � WindowStartupLocation$ CenterScreen=�5   
    � Title$ AddAccountWd��5   	   $	��470��6   $	��800��6+    � AllowsTransparency . ��67   Z� .��5      �� ���#08c424 �� CornerRadius$ 40��6"   $��1q�64   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      6"   .+�5      �� 
���"�"�$ 10��6/   $��2q�6B   $��0��6V   $��Center=�5   	   ���#25b24a$��Center=�69   ._�5      � .+�5      �� $��THÊM MỚI��6    
�������$��Center=�6C    �� Padding$ 20 10q�6^   $��Center=�5   	   $��18(�6&   66   5      5      �� 5      $��30 10 30 30q�6   $ 40��6*   $��1��6<   
�������
�������$��1q�6o   ._�5      �  5       �� 5!      $
��auto �6(   68   �� 5"      $
��auto �6(   68   �� 5#      $
��auto �6(   68   .+�5%      � .+�5&      �� $��Center=�6$   $��18(�6A   $��Thông tin tài khoản��6O   
�������$��0 20 0 0q�6|   5'      5(      � 5)      $��1��6   	 � ColumnDefinitions	 5*      �� 5+      61   �� 5,      61   .+�5.      � $��0��6    5/      �� 50   "   62   �� 51   "   62   �� 52   "   62   .+�54      � $��0��6#   $��
20 20 20 0q�60   .+�55   "   �� .+�56   &   �� 
��� � �)  #MaterialDesignThemes.Wpf.HintAssist
   
Foreground

 � � �$��Center=�58   !      Hint$ Tên tài khoản��59   !    �� 	MaxLength$ 20��5:   !    ! MaterialDesignOutlinedTextBox#��[ 5;   !   ��56   B   �� *New.UserName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��5;   X   .  (System.Windows.Interactivity.Interaction   Triggers 5<   *   /  )System.Windows.Interactivity.EventTrigger  5=   .      	EventName$ GotFocus��6=   .  (System.Windows.Interactivity.TriggerBase   Actions. 5>   2   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6H   �� *UsernameEmpty+5?   /   .��5@   B   5A   '   �� 5B   &   $��Bottom=�5C   !   
���  ����5B   0   �� *ErrorMessageUser+$ OneWay=�$ PropertyChanged=�5C   O   5D   #   5E      � 5F      $��1��6#   $��20q�60   .+�5G   "   G� -   5         G�Name$ Pass1��5H   9   
��� � �$	��Top=�6!   $ Nhập Mật Khẩu��5I   !    % !MaterialDesignOutlinedPasswordBox#��[ 5J   !    5K   &     5L   *   $ PasswordChanged��69   . 5M   .        CommandParameter 6D   ��  �� ElementName$ Pass1�� 6s   �� *Password1ChangedCommand+5N   +   5P   #   5Q      � 5R      $��2��6#   $��
20 20 20 0q�60   .+�5S   "   �� .+�5T   &   G� -   5        $ Pass2��5U   =   
��� � �$	��Top=�6%   $ Nhập Lại Mật Khẩu��5V   %   #��[ 5W   %    5X   *     5Y   .   $ PasswordChanged��6=   . 5Z   2      6H   �� $ Pass2�� 6w   �� *Password2ChangedCommand+5[   /     5\   .   $ GotFocus��6=   . 5]   2      6I   �� *PasswordEmpty+5^   /   5`   '   �� 5a   &   $��Bottom=�5b      
���  ����5a   0   �� *ErrorMessagePassword+$ TwoWay=�$ PropertyChanged=�5b   M   5c   #   5d      5e      � 5f      $��1��6    5g      �� 5h   "   62   �� 5i   "   62   �� 5j   "   62   .+�5l      � $��1��6#   $��20q�60   .+�5m   "   �� 
��� � �

 � � �$ 	Họ tên��5o   %    " MaterialDesignOutlinedComboBox#��[ 5p   %    �� SelectedValue 5m   ?   �� *New.FullName+$ PropertyChanged=�$ TwoWay=���5n   R   �� *	ListHoten+ 5q   &     5r   *   $ SelectionChanged��69   . 5s   .      6E   �� *SelectFullName+5t   +   5v   #   5w      � 5x      $��0��6#   $��20q�60   .+�5y   "   �� 
��� � �

 � � �$ Chức vụ��5{   %   #��[ 5|   %    5y   ?   �� *	New.Roles+$ PropertyChanged=�$ TwoWay=���5z   R   �� *
ListChucVu+ 5}   &     5~   *   $ SelectionChanged��69   . 5   .      6E   �� *
SelectRole+ 6d   �� $ 
TextNumber��5�   +   5�   #   5�      � 5�      $��2��6#   $��20q�60   .+�5�   "   �� -   5         ��Name$ 
TextNumber��5�   <   
��� � �

 � � �$��Center=�6!   $ Số Điện Thoại��5�   !   $ 10��5�   !    �� 
IsReadOnly . #��[ 5�   !   ��5�   >   �� *SDT+$ PropertyChanged=�$ TwoWay=�.��5�   X   5�   #   5�      5�      5�      � 5�      $��2��6   	 5�      �� 5�      61   �� 5�      61   .+�5�      �� $��0��6!   $	��120��61   $
��20 0q�6=   $��Thêm��5�      
����������#08c424���#08c424 � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   K   �� *
addCommand+��6j   �� $ addAccountWd��5�      �� 5�      $��1��6!   $	��120��61   $
��20 0q�6=   $��Thoát��5�      
�������
��� E��
��� E��$4 .Resource name: MaterialDesignRaisedLightButton��5�      ��5�   K   �� *closeCommand+��6l   �� $ addAccountWd��5�      5�      5�      5�      5�      5�      5�      