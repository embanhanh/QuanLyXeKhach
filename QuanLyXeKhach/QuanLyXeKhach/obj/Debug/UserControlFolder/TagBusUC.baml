   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5      .    (QuanLyXeKhach.UserControlFolder.TagBusUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:QuanLyXeKhach.UserControlFolder     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��ucTagBus��5      $��5q�5
       
  MainVM  � DataContext#  [  6)    J� Opacity$	 0.8Q�5   6   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ 	MouseDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     CommandParameter 6$   ��  �� ElementName$ ucTagBus��   Command 6V   �� *SelectTagBus+5        5   
   $ GotFocus��6   . 5         6$   �� $ ucTagBus�� 6V   �� *SelectTagBus+5      .��5      �� ���#C1F2B0 �� CornerRadius$ 15��6$   $��1q�66   
�������._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��0.6* �6#   62   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   .+�5      � $��0��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$	
 Bus=�6*   $	��100��65   $	��100��6B   $��Center=�6N   5       � 5!      $��1��6    � RowDefinitions 5"      �� 5#      6&   �� 5$      6&   .+�5&      � $��0��6   .+�5'      �� -   5         ��Name$ BienSoXe��5)   1   $��2q�5'      
���   �)  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 �   �$��Center=�5)         
Background �#C1F2B0   Hint$ Biển Số Xe��5+      $	��300��6B    �� 
IsReadOnly . $	��1.5q�5,   (    �� TextAlignment$ Center=�6>    ! MaterialDesignOutlinedTextBox#��[ 5-      $��8q�5.      5/      � 50      $��1��6   .+�51      �� -   5        $ LoaiXe��57      $��2q�51      
���   �
 �   �$��Center=�53      $	��300��61    . $	��1.5q�54   )    �#C1F2B0$ 	Loại Xe��56      $ Center=�57   &   #��[ 58      $��8q�59      5:      5;      � 5<      $��3��6    5=      �� 5>      6&   �� 5?      6&   .+�5A      � $��0��6   .+�5B      �� -   5        $ SoGhe��5F      $��2q�5B      
���   �
 �   �$ 
Số Ghế��5D      $	��150��6>    �#C1F2B0$ Center=�5F   %    . $	��1.5q�5G   )   $��Center=�5H      #��[ 5I      $��8q�5J      5K      � 5L      $��1��6   .+�5M      �� -   5        $ 	TinhTrang��5R      $��2q�5M      
���   �
 �   �$��Center=�5O      $	��300��61    �#C1F2B0$ Tình Trạng��5Q      $ Center=�5R   )    . $	��1.5q�5S   )   #��[ 5T      $��8q�5U      5V      5W      � 5X      $��2��6    5Y      �� 5Z      6&   �� 5[      6&   .+�5]      � $��0��6   .+�5^      �� -   5        $ TX��5b      $��2q�5^      
���   �
 �   �$ 	Tài Xế��5`       �#C1F2B0$	��1.5q�5b   #    . $ Center=�5c   (   $��Center=�5d      $	��300��60   #��[ 5e      $��8q�5f      5g      � 5h      $��1��6   .+�5i      �� -   5        $ PX��5m      $��2q�5i      
���   �
 �   �$��Center=�5k      $	��300��61    . $	��1.5q�5l   )   $ Center=�5m   #    �#C1F2B0$ Phụ Xe��5o      #��[ 5p      $��8q�5q      5r      5s      5t      5u      5v      