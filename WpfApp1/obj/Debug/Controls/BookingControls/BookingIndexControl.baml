   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WpfApp1.Controls.BookingControls WpfApp1.Controls.BookingControls  5      :    4WpfApp1.Controls.BookingControls.BookingIndexControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:WpfApp1.Controls.BookingControls     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �� $��20q�6   .+�5   
   ��  # MaterialDesignDisplay4TextBlock#��[ 6   $��30(�5      $��DemiBold"�5      $��Quản Lý Bookings��5       �� TextAlignment$ Center=�6,   
��� E��5   -   �� 5   
   -   5         ��Name$ CustomerNameTextBox��5      $��Stretch=�5      $��10q�5      $��25(�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên Khách Hàng��5   /   ��5      �� *CustomerName+5   /   �� 5   
   -   5        $ MobileTextBox��5       $��Stretch=�5      $��10q�5      $��25(�5      $ Số Điện Thoại��5    )   ��5      �� *PhoneNumber+5    )   �� 5!   
   -   5         ��Name$ RoomTypeComboBox��5#      $ Loại Phòng��5!       �� 
IsEditable . $��10q�5$      $��25(�5%       �� Text 5&      �� *
RoomType+(  "System.Windows.Controls.DatePicker  5'   
   $
��Auto��6   $��Stretch=�6"   $��10q�6@   $ Ngày Nhận Phòng��5(       ( $MaterialDesignFloatingHintDatePicker#��[ 5)      $��25(�5*         SelectedDate 5+      �� 	 �� Path$	 CheckInDate�
 �� StringFormat$
 
dd/MM/yyyy��)  #MaterialDesignThemes.Wpf.TimePicker  5,   
      	Is24Hours . $��10q�65   $��25(�6k      SelectedTime 6A   �� $	 CheckInTime�6k   �� 5-   
   -   5        $ NoteTextBox��50      $��10q�5-      $��Stretch=�6   $��25(�5/      $ Yêu Cầu Khác��50   '   ��5.      �� *Note+50   '   �� 51   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�52      ��  " MaterialDesignRaisedDarkButton#��[ 6   $��10q�53       �� 	IsDefault . $	��150��55      $��25(�56      $��Stretch=�57      $��50��58      $
��Lưu��5:      ��59      �� *SaveCommand+5:      5;      �� 5<   
   -   5         ��Name$ BookingListView��5<      $��Center=�6,   $��Center=�5>      $��25(�5?      $��10q�5A      ��5@      �� *
Bookings+ �� Mode$ OneWay=� �� SelectedItem 5B      �� *	Booking+��5C      �� 5D       �� 
TargetType" ��6   .�5E      ��  �� Property � �� �� Value$ Stretch=�6C   �� 5F       � ��
 �����64   �� 5G       � ��$ 0,0,0,1q�68   5H       �� View 5J      �� 5K      .P�5L      �� $��Tên Khách Hàng��6S    �� DisplayMemberBinding 6%   �� *CustomerName+6S   �� 5M      $��Số Điện Thoại��6R    6%   �� *PhoneNumber+6R   �� 5N      $��Phòng Muốn Đặt��6O    6%   �� *
RoomType+6O   �� 5O      $��Nhận Phòng Lúc��6s    6%   �� *CheckInDate+$
 dd/MM/yyyy HH:mm��6s   �� 5P      $��
Yêu Cầu��6K    6%   �� *Note+6K   5Q      5S      5T      5U      