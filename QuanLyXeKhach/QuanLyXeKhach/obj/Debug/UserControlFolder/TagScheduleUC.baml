   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5      3    -QuanLyXeKhach.UserControlFolder.TagScheduleUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:QuanLyXeKhach.UserControlFolder     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��ucTag��5   #   $��5q�5
       
  MainVM  � DataContext#  [  6*    J� Opacity$	 0.8Q�5   7   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ 	MouseDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     CommandParameter 6$   ��  �� ElementName$ ucTag��   Command 6S   �� *SelectTagSchedule+5        5   
   $ GotFocus��6   . 5         6$   �� $ ucTag�� 6S   �� *SelectTagSchedule+5      .��5      �� ���#C1F2B0 �� CornerRadius$ 15��6$   $��1q�66   
�������._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��0.8* �6#   62   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $
��0.7* �6#   62   .+�5      � $��0��6   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6*   $��Center=�6G   
   Kind$
 BusSide=�5!      $	��100��6    $	��100��6-   5"      � 5#      $��1��6    � RowDefinitions 5$      �� 5%      6&   �� 5&      6&   .+�5(      � $��0��6   .+�5)      �� -   5         ��Name$ BienSoXe��5+      $��2q�5)      
���   �$	��1.5q�5*       �� 
IsReadOnly .  �� TextAlignment$ Center=�5,   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Biển số xe��5-         
Background �#C1F2B0   
Foreground
 �   �$��Center=�50       ! MaterialDesignOutlinedTextBox#��[ 51      $��8q�52      53      � 54      $��1��6   .+�55      �� -   5        $ GiaVe��56   -   $��2q�55      
���   �$	��1.5q�6=   $��Center=�56      $ Center=�6<    �#C1F2B0$ Giá vé��58       . 
 �   �#��[ 5:      $��8q�5;      5<      5=      � 5>      $��2��6    5?      �� 5@      6&   �� 5A      6&   .+�5C      � $��0��6   .+�5D      �� -   5        $ BenXuatPhat��5D   S   $��2q�6   
���   �$	��1.5q�6=   $ Bến Xuất Phát��5E       .  �#C1F2B0$��Center=�5G      $ Center=�60   
 �   �#��[ 5I      $��8q�5J      5K      � 5L      $��1��6   .+�5M      �� -   5        $ 
BenKetThuc��5N   1   $��2q�5M      
���   �$	��1.5q�6=   $��Center=�5N       .  �#C1F2B0$ Bến Kết Thúc��5P      $ Center=�6C   
 �   �#��[ 5R      $��8q�5S      5T      5U      � 5V      $��3��6    5W      �� 5X      6'   �� 5Y      6&   .+�5[      � $��0��6   .+�5\      �� -   5        $ ThoiGianXuatPhat��5]   0   $��2q�5\      
���   �$	��1.5q�6=   $��Center=�5]      $ Center=�6J   $ Thời gian xuất phát��5^       .  �#C1F2B0
 �   �#��[ 5a      $��8q�5b      5c      � 5d      $��1��6   .+�5e      �� -   5        $ ThoiGianDuKien��5f   0   $��2q�5e      
���   �$	��1.5q�6=   $��Center=�5f      $ Center=�6H   $ ThoiGianDuKien��5g       .  �#C1F2B0
 �   �#��[ 5j      $��8q�5k      5l      5m      � 5n      $��4��6   .+�5o      �� -   5        $ ID��5p      
���   �$ Center=�5o   .    . $	��1.5q�5p   /   $��Center=�5q      $��Center=�6,    �#C1F2B0$ ID��5s      
 �   �#��[ 5u      $��10q�5v      $��10q�6   5w      5x      5y      5z      