   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:WpfApp1.Controls.ReportControlsWpfApp1.Controls.ReportControls  5      8    2WpfApp1.Controls.ReportControls.ReportIndexControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:WpfApp1.Controls.ReportControls     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �� $��16q�6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      (  "System.Windows.Controls.DatePicker  $
��Auto��6   $
��Left=�6&   $��0 0 16 0q�6A   $��Center=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Từ Ngày��5       ( $MaterialDesignFloatingHintDatePicker#��[ 5         SelectedDate 5      ��  �� Path$ FromDate�  5      $
��Auto��6   $
��Left=�6&   $��0 0 16 0q�6A   $ Đến Ngày��5      $��Center=�5      #��[ 5       5      �� $ ToDate��� 5      $ 
Lọc Theo��6   $��0 0 16 0q�5       �� SelectedIndex 5      �� *
ViewType+.@�5       �� .��6   Ngày6%   �� 5!      .��6   Tháng6&   �� 5"      .��6   Năm6$   5#      �� 5$       # MaterialDesignRaisedLightButton#��[ 6   $��10q�5%      $��Center=�5&      $	��Xem��5'      ��5(      �� *ViewCommand+�� 5)      #��[ 6   $��10q�5*      
�������$��Center=�5,      $��
Lưu Excel��5-      ��5.      �� *ExportCommand+5/      �� 50   
   -   5         ��Name$ ReportListView��50      $��Center=�6+   ��51      �� 52       �� 
TargetType" ��6   .�53      �� 	 �� Property	 � ��
 �� Value$
 Stretch=�6C   �� 54      	 � ��

 �����64   �� 55      	 � ��$
 0,0,0,1q�68   56       �� View 58      �� 59      .P�5:      �� $��Phòng��6P    �� DisplayMemberBinding 6%   �� *	Room.Name+6P   �� 5;      $��Dịch Vụ��6%    �� Width$	 500��66    �� CellTemplate 5<      �� 5=      .R�5>   "   &   System.Windows.Controls.DataGrid    Name$ ServiceDataGrid��6+      GridLinesVisibility$
 None=�6g      HeadersVisibility$
 None=�5?   +      AutoGenerateColumns .     CanUserAddRows .  $��Stretch=�5@   +   $��0q�6I   ��5>   D   �� *
OrderLines+   Columns 5A   &   0  *System.Windows.Controls.DataGridTextColumn  5B   *   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Service.Name+6k     5C   *   $ 50 6k    6=   �� *
Quantity+ �� StringFormat$ N0��6x     5D   *   $	 100 6h    6=   �� *Total+$ N0��   ElementStyle 5E   .   �� 5F   2   " ��68   .�5G   6   �� 	 � ��$
 Right=�6\   5H   3   5J   +   5L   #   5M      5O      �� 5P      $��Giảm Giá��6%    5Q      �� 5R      .R�5S   "   ��  �� TextAlignment$ Center=�6^   ��6,   �� $ Discount�$ N0��6^   5T      5V      �� 5W      $��	Phụ Thu��6%    5X      �� 5Y      .R�5Z   "   �� $ Center=�6`   ��6,   �� $ 
Adjustment�$ N0��6`   5[      5]      �� 5^      $��Tổng Cộng��6%    5_      �� 5`      .R�5a   "   �� $ Right=�6T   $
��Bold"�6j   
��� E����6,   �� *Total+$ N0��6|   5b      5d      5e      5g      5h      5i      