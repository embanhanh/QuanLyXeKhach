   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5      1    +QuanLyXeKhach.UserControlFolder.TagClientUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:QuanLyXeKhach.UserControlFolder     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��ucTag��5      $��5q�5
       
  MainVM  � DataContext#  [  6*    J� Opacity$	 0.8Q�5   7   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ 	MouseDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     CommandParameter 6$   ��  �� ElementName$ ucTag��   Command 6S   �� *SelectTagClient+5        5   
   $ GotFocus��6   . 5         6$   �� $ ucTag�� 6S   �� *SelectTagClient+5      .��5      �� ���#C1F2B0 �� CornerRadius$ 15��6$   $��1q�66   
�������._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��0.8* �6#   62   �� 5      $
��1.5* �6#   62   �� 5      $
��0.5* �6#   62   �� 5      $��2* �6#   60   �� 5      $
��0.7* �6#   62   .+�5      � $��0��6   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6*   $��Center=�6G   
   Kind$
 AccountCircle=�5!      $	��100��6*   $	��100��67   5"      � 5#      $��1��6    � RowDefinitions 5$      �� 5%      6&   �� 5&      6&   .+�5(      � $��0��6   .+�5)      �� -   5         ��Name$ TenHanhKhach��5+      $��2q�5)      
���   �$	��1.5q�5*       �� 
IsReadOnly .  �� TextAlignment$ Center=�5,   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Họ và tên��5-         
Background �#C1F2B0   
Foreground
 �   �$��Center=�50       ! MaterialDesignOutlinedTextBox#��[ 51      $��8q�52      53      � 54      $��1��6   .+�55      �� -   5        $
 CCCD��56   1   $��2q�55      
���   �$	��1.5q�6=   $��Center=�56      $ Center=�6?    �#C1F2B0$
 CCCD��58       . 
 �   �#��[ 5:      $��8q�5;      5<      5=      � 5>      $��2��6    5?      �� 5@      6&   �� 5A      6&   .+�5C      � $��0��6   .+�5D      �� -   5        $
 Tuoi��5D   S   $��2q�6   
���   �$	��1.5q�6=   $
 Tuoi��5E       .  �#C1F2B0$��Center=�5G      $ Center=�64   
 �   �#��[ 5I      $��8q�5J      5K      � 5L      $��1��6   .+�5M      �� -   5        $ GioiTinh��5N   5   $��2q�5M      
���   �$	��1.5q�6=   $��Center=�5N       .  �#C1F2B0$ 	Gioi Tinh��5P      $ Center=�6D   
 �   �#��[ 5R      $��8q�5S      5T      5U      � 5V      $��3��6    5W      �� 5X      6'   �� 5Y      6&   .+�5[      � $��0��6   .+�5\      � .+�5]      �� -   5        $	 SDT��5^   8   $��2q�5]   "   
���   �$	��1.5q�6A   $��Center=�5^      $ Center=�6E   $	 SDT��5_       .  �#C1F2B0
 �   �#��[ 5b      $��8q�5c      5d      5e      � 5f      $��1��6   .+�5g      �� -   5        $ DiaChi��5h   4   $��2q�5g      
���   �$	��1.5q�6=   $��Center=�5h      $ Center=�6D   $ Dia chi��5i       .  �#C1F2B0
 �   �#��[ 5l      $��8q�5m      5n      5o      � 5p      $��4��6   .+�5q      �� -   5        $ IDHanhKhach��5r      
���   �$ Center=�5q   .    . $	��1.5q�5r   <   $��Center=�5s      $��Center=�60    �#C1F2B0$ ID��5u      
 �   �#��[ 5w      $��10q�5x      $��10q�6#   5y      5z      5{      5|      