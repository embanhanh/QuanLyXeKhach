   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5      0    *QuanLyXeKhach.UserControlFolder.TagStaffUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:QuanLyXeKhach.UserControlFolder     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��ucTag��5   -   $��5q�5
       
  MainVM  � DataContext#  [  6*    J� Opacity$	 0.8Q�5   7   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ 	MouseDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     CommandParameter 6$   ��  �� ElementName$ ucTag��   Command 6S   �� *SelectTagStaff+5        5   
   $ GotFocus��6   . 5         6$   �� $ ucTag�� 6S   �� *SelectTagStaff+5      .��5      �� ���#C1F2B0 �� CornerRadius$ 15��6$   $��1q�66   
�������._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��0.8* �6#   62   �� 5      $��1.25* �6#   63   �� 5      $��1.25* �6#   63   �� 5      $��2* �6#   60   �� 5      $
��0.8* �6#   62   .+�5      � $��0��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6*   
   Kind$
 
AccountTie=�5       $	��100��6#   $	��100��60   5!      � 5"      $��1��6    � RowDefinitions 5#      �� 5$      6&   �� 5%      6&   .+�5'      � $��0��6   .+�5(      �� -   5         ��Name$ HoTen��5)      $��2q�5(      
���   � �� TextAlignment$ Center=�5)   $    �� 
IsReadOnly . $	��1.5q�5*   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Họ và tên��5+         
Background �#C1F2B0   
Foreground
 �   �$��Center=�5.       ! MaterialDesignOutlinedTextBox#��[ 5/      $��8q�50      51      � 52      $��1��6   .+�53      �� -   5        $
 CCCD��54   1   $��2q�53      
���   �$��Center=�54      $ Center=�6?    �#C1F2B0$	��1.5q�55   D   $
 CCCD��56       . 
 �   �#��[ 58      $��8q�59      5:      5;      � 5<      $��2��6    5=      �� 5>      6&   �� 5?      6&   .+�5A      � $��0��6   .+�5B      �� -   5        $ NgaySinh��5C      $��2q�5B      
���   �$ Center=�5C   '   $ 
Ngày sinh��5D       .  �#C1F2B0
 �   �$��Center=�5G      $	��200��60   $	��1.5q�6?   #��[ 5H      $��8q�5I      5J      � 5K      $��1��6   .+�5L      �� -   5        $ GioiTinh��5M   1   $��2q�5L      
���   �$	��200��6=   $��Center=�5M       .  �#C1F2B0$	��1.5q�5N   D   $ Giới tính��5O      $ Center=�6@   
 �   �#��[ 5Q      $��8q�5R      5S      5T      � 5U      $��3��6    5V      �� 5W      6'   �� 5X      6&   .+�5Z      � $��0��6   .+�5[      �� -   5        $	 SDT��5\   0   $��2q�5[      
���   �$	��1.5q�6=   $��Center=�5\      $ Center=�6=   $	 SDT��5]       .  �#C1F2B0
 �   �#��[ 5`      $��8q�5a      5b      � 5c      $��1��6   .+�5d      �� -   5        $ DiaChi��5e   0   $��2q�5d      
���   �$	��1.5q�6=   $��Center=�5e      $ Center=�6@   $ Dia chi��5f       .  �#C1F2B0
 �   �#��[ 5i      $��8q�5j      5k      5l      � 5m      $��4��6   .+�5n      �� -   5        $ Luong��5o      
���   �$	��1.5q�5n   .    . $��Center=�5p      $��Center=�6,    �#C1F2B0$ Lương��5r      $ Center=�68   
 �   �#��[ 5t      $��10q�5u      5v      5w      5x      5y      