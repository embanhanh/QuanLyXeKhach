   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5      5    /QuanLyXeKhach.UserControlFolder.TagBusStationUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:QuanLyXeKhach.UserControlFolder     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��ucTag��5   ,   $��5q�5
       
  MainVM  � DataContext#  [  6*    J� Opacity$	 0.8Q�5   6   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ 	MouseDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     CommandParameter 6$   ��  �� ElementName$ ucTag��   Command 6S   �� *SelectTagBusStation+5        5   
   $ GotFocus��6   . 5         6$   �� $ ucTag�� 6S   �� *SelectTagBusStation+5      .��5      �� ���#C1F2B0 �� CornerRadius$ 15��6$   $��1q�66   
�������._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��0.8* �6#   62   �� 5      $��1.25* �6#   63   �� 5      $��1.25* �6#   63   �� 5      $��2* �6#   60   �� 5      $
��0.6* �6#   62   .+�5      � $��0��6   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6*   
   Kind$
 	BusMarker=�5!      $��80��6"   $��80��6.   5"      � 5#      $��1��6   .+�5$      � .+�5%      �� -   5         ��Name$ TenBenXe��5&   0   $��2q�5%      
���   �$	��1.5q�6=   $��Center=�5&       �� TextAlignment$ Center=�6B   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên bến xe��5'       �� 
IsReadOnly .    
Background �#C1F2B0$��14(�5(   E      
Foreground
 �   � ! MaterialDesignOutlinedTextBox#��[ 5*      $��8q�5+      5,      5-      � 5.      $��2��6   .+�5/      � .+�50      �� -   5        $	 SDT��51   4   $��2q�50      
���   �$	��1.5q�6=   $��Center=�51      $ Center=�6A   $ Số điện thoại��52       .  �#C1F2B0$��14(�53   I   
 �   �#��[ 55      $��8q�56      57      58      � 59      $��3��6   .+�5:      � .+�5;      �� -   5        $ DiaChi��5<   4   $��2q�5;      
���   �$	��1.5q�6=   $��Center=�5<      $ Center=�6D   $ Địa chỉ��5=       .  �#C1F2B0$��14(�5>   H   
 �   �#��[ 5@      $��8q�5A      5B      5C      � 5D      $��4��6   .+�5E      �� -   5        $ ID��5F      
���   �$	��1.5q�5E   .    . $��Center=�5G      $��Center=�6,    �#C1F2B0$ ID��5I      $ Center=�65   
 �   �#��[ 5K      $��10q�5L      5M      5N      5O      5P      