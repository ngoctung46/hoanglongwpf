   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WpfApp1.Controls.ServiceControls WpfApp1.Controls.ServiceControls  5      5    /WpfApp1.Controls.ServiceControls.ServiceControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:WpfApp1.Controls.ServiceControls     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �� $��15q�6   .+�5   
   �� $��Center=�6   Thêm Dịch Vụ6?   �� 5   
   -   5         ��Name$ NameComboBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Tên��5       �� 
IsEditable .  �� DisplayMemberPath$
 Name��5       �� Text 5      �� *ServiceName+ �� SelectedValue 5      �� *	Service+5      �� 5   
   -   5         ��Name$ PriceTextBox��5      $��Stretch=�5       % !MaterialDesignFloatingHintTextBox#��[ 60   $
 Giá��5   (   ��6M   �� *Price+	 �� StringFormat$	 N0���� 5   
   -   5        $ QuantityTextBox��5      $��Stretch=�5      #��[ 60   $ Số Lượng��5   +   ��6U   �� *
Quantity+$	 N0���� 5   
   -   5        $ TotalTextBox��5      $��Stretch=�5      #��[ 60   $ Tổng Cộng��5   (   ��6S   �� *Total+$	 N0��
 �� Mode$
 OneWay=��� 5    
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5!      ��  # MaterialDesignRaisedLightButton#��[ 6   $��10q�5"      $��Center=�5#      $��Thêm��5$      ��5%      �� *
AddCommand+�� 5&      #��[ 6   $��10q�5'      $��Center=�5(      $��Hủy��5)      ��5*      �� *CloseCommand+5+      5,      5-      