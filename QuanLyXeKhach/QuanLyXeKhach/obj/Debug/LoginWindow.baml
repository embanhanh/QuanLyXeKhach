   M S B A M L   `   `   `  ����H  DQuanLyXeKhach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyXeKhachQuanLyXeKhach  5   	   Q-clr-namespace:QuanLyXeKhach.UserControlFolderQuanLyXeKhach.UserControlFolder  5
   	       QuanLyXeKhach.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyXeKhach     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   8uccb-clr-namespace:QuanLyXeKhach.UserControlFolder  5
   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��LoginWd��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	     LoginVM � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$  ��5   	   $	��400��6   $	��600��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5       2   ,QuanLyXeKhach.UserControlFolder.ControlBarUC  
 � Tag 6    �� *Title+	 �� ElementName$	 LoginWd��6M   5!      #  MaterialDesignThemes.Wpf.Card  5"   
   $��100 30q�6   $��1��6.   $	��400��6;   $	��400��6K   .��5#      �  5$      �� 5%      $	��100��6$   66   �� 5&      $	��100��6$   66   �� 5'      $	��100��6$   66   �� 5(      $	��100��6$   66   .+�5+      �� 
��� � �$��0 0 0 1q�6-   $��0��6G   ._�5,      �� 
���"�"�$��2q�67   $��Center=�5-      ���#25b24a$��Center=�6E   
 J� Effect
 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/         Color$
 Gray��6/      Opacity$	 0.5Q�6<   6L   ._�51      � .+�52      �� $��Đăng nhập��6(   
�������$��Center=�6L    �� Padding$ 20 10q�6g   $��Center=�53      $��18(�66   6F   54      55      56      � 58      $��1��6   .+�59      �� -   5         ��Name$ userName��59   :   $��30 15q�6   $��40��6.   $��Center=�5:      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��5;         
Foreground
 � � � % !MaterialDesignFloatingHintTextBox#��[ 5>      ��5:   4   �� *
Username+.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush 5=      �� *
ColorHint1+.��5>   T   .  (System.Windows.Interactivity.Interaction   Triggers 5?      /  )System.Windows.Interactivity.EventTrigger  5@         	EventName$ GotFocus��6-   .	  (System.Windows.Interactivity.TriggerBase 	  Actions. 5A   "   6
  0System.Windows.Interactivity.InvokeCommandAction
   
  Command 68   �� *UsernameEmpty+5B        5C      $ TextChanged��6-   . 5D   "   
   68   �� *UsernameEmpty+5E      .��5F   2   5G      �� 5H      $
��30 0q�5I      $��Bottom=�6(   
���  ����5H       �� *ErrorMessage1+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5I   V   5J      � 5L      $��2��6   .+�5M      G� -   5         G�Name$ FloatingPasswordBox��5N      $��30 15q�5M   #   $��40��62   
 � � �$ Mật khẩu��5P       ) %MaterialDesignFloatingHintPasswordBox#��[ 5R       5Q      �� *
ColorHint2+ 5S        5T      $ PasswordChanged��6-   . 5U   "   
   
  CommandParameter 68   �� $	 FloatingPasswordBox�� 6u   �� *PasswordChangedCommand+5V        5W      $ GotFocus��6-   . 5X   "   
   69   �� *PasswordEmpty+5Y      5[      �� 5\      $
��30 0q�5]      $��Bottom=�6(   
���  ����5\       �� *ErrorMessage2+$ OneWay=�$ PropertyChanged=�5]   V   5^      � 5_      $��3��6    � ColumnDefinitions 5`      �� 5a      6-   �� 5b      6-   .+�5e      �� $��0��6   $	��100��5f      
��� � � �� 	IsDefault . $��Đăng nhập��5g       " MaterialDesignPaperLightButton#��[ 5i       � ToolTip$3 -Resource name: MaterialDesignPaperLightButton��5j      ��5e   -   �� $	 LoginWd����5g   -   �� *LoginWindowCommand+{�5h      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5l      �� 5n      $��1��6   $	��100��5o      
���  ��$��Thoát��5p      #��[ 5r      $3 -Resource name: MaterialDesignPaperLightButton��5s      ��5n   -   �� $	 LoginWd����5p   )   �� *CloseLgWdCommand+{�5q      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5s      5t      5u      5v      5w      5x      