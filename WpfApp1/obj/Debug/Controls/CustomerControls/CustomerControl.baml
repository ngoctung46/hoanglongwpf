   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:WpfApp1.Controls.CustomerControls!WpfApp1.Controls.CustomerControls  5      9!clr-namespace:WpfApp1.ValidationsWpfApp1.Validations  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      7    1WpfApp1.Controls.CustomerControls.CustomerControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:WpfApp1.Controls.CustomerControls     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3validations!clr-namespace:WpfApp1.Validations  5      3system&clr-namespace:System;assembly=mscorlib  5	         MaterialDesignBody#���   5      $��Regular"�5      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $
��Auto��5   7   .��5      �� $��16q�6   $	��500��6   $
��Auto��6)   .+�5   
   �� 
Check In6   �� 5   
   -   5         ��Name$ 
IdComboBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Số CMND/Hộ Chiếu��5       �� 
IsEditable . $��0 0 16 0q�5       �� Text 5      ��  �� Path$ Identity��� 5   
   -   5         ��Name$ IdentityInfoStackPanel��5   [    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��0 16 0 0q�6I   .+�5      (  "System.Windows.Controls.DatePicker  $
��Auto��6   $
��Left=�6&   $��0 0 16 0q�6A   $ Ngày Cấp��5   %    ( $MaterialDesignFloatingHintDatePicker#��[ 5   %   	   SelectedDate	 5    %   �� $ Customer.IssueDate�  5"      $
��Auto��6   $��0 0 16 0q�6&   $
��Left=�5#   %   #��[ 5$   %   $ Ngày Hết Hạn��5%   %   	 5&      �� 5'      $ Customer.ExpiryDate�6   
 �� ValidationRules
 5(      2   ,WpfApp1.Validations.FutureDateValidationRule  5)      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 6C   5+      5-      �� 5.      -   5        $ IssuePlaceComboBox��5.      $ 
Nơi Cấp��63    .  50   #   �� $ Customer.IssuePlace�51      52      �� 53   
   -   5         ��Name$ CustomerNameTextBox��54      $��0 16 0 0q�53      $��Stretch=�6$   $ Họ Và Tên��54   ;   .��6f   ��55      �� 56      $ Customer.Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6/   
 57      0   *WpfApp1.Validations.NotEmptyValidationRule  58       . 6=   5:      .��5;      5<      �� 5=   
   -   5        $ BirthInfoStackPanel��5=   [   $ 
Horizontal=�6   $
��Left=�6.   $��0 16 0 0q�6I   .+�5>        $	��100��6   $
��Left=�6%   $��0 0 16 0q�5?   %   $ 
Ngày Sinh��67   #��[ 5@   %   	 5A   %   �� $ Customer.BirthDate��� 5B      -   5        $ BirthPlaceComboBox��5D   %   $ 	Nơi Sinh��5B       . $��0 0 16 0q�5E   %    5F   %   �� $ Customer.BirthPlace�5G      5H      �� 5I   
   -   5        $ AddressInfoStackPanel��5I   [   $ 
Horizontal=�6   $
��Left=�6.   $��0 16 0 0q�6I   .+�5J      �� -   5        $ AddressLine1TextBox��5K   "   $��0 16 8 0q�5J      $��Stretch=�6(   $ Địa Chỉ Dòng 1��5K   ?   ��5L   "   �� $ Customer.AddressLine1�.��6N   5M      �� 5N      -	   5        $ AddressLine2TextBox��5O   "   $��0 16 8 0q�5N      $��Stretch=�6(   $ Địa Chỉ Dòng 2��5O   ?   ��5P   "   �� $ Customer.AddressLine2�.��6N   5Q      �� 5R      -
   5        $ CitiesComboBox��5T   #   $ Thường Trú Tại��5R       . $��0 16 8 0q�5U   #    5V   #   �� $ Customer.City�5W      �� 5X      -   5        $ CountriesComboBox��5Y   #   $ Quốc Tịch��5X       . $��0 16 8 0q�5[   #    5\   #   �� $ Customer.Country�5]      5^      �� 5_   
   $ 
Horizontal=�6   $
��Left=�6.   $��0 16 0 0q�6I   .+�5`        $
��Auto��6   $
��Left=�6&   $��0 0 16 0q�6A   $ Thời Gian Nhận Phòng��5a      #��[ 5b      	 5c      �� $ Customer.CheckInDate� �� StringFormat$ 
dd/MM/yyyy��)  #MaterialDesignThemes.Wpf.TimePicker  5d         	Is24Hours . $��0q�69      SelectedTime 6D   �� $ CheckInTime�5e      �� 5f   
   $ 
Horizontal=�6   $
��Left=�6.   $��0 16 0 0q�6I   .+�5g        $
��Auto��6   $
��Left=�6&   $��0 0 16 0q�6A   $ Thời Gian Trả Phòng��5h      #��[ 5i      	 5j      �� $ Customer.CheckOutDate�$ 
dd/MM/yyyy��  5k       . $��0q�69    6D   �� $ CheckOutTime�5l      �� 5m   
   $ 
Horizontal=�6   $��Right=�6.   .+�5n      �� -   5         ��Name$ AcceptButton��5o        MaterialDesignFlatButton#��[ 5n       �� 	IsDefault . $��0 8 8 0q�5q      $��Nhận Khách��5s      ��5r      �� *AcceptCommand+5s      �� 5u      #��[ 6    �� IsCancel . $��0 8 8 0q�5w      $2��,materialDesign:DialogHost.CloseDialogCommand��5x      ��5y      ��5z      	False��6,   .��5{   +   Hủy5}      5~      5      5�      