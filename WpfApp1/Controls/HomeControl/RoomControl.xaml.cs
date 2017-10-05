using MaterialDesignThemes.Wpf;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.ViewModel.HomeControl;

namespace WpfApp1.Controls.HomeControl
{
    

    public partial class RoomControl : UserControl, IViewFor<RoomControlViewModel>
    {
        public RoomControl(Room room)
        {
            InitializeComponent();
            Room = room;
            ViewModel = new RoomControlViewModel(Room);
            DataContext = ViewModel;
            this.WhenActivated(d => BindView(d));
        }

        private void BindView(Action<IDisposable> d)
        {
            d(this.BindCommand(ViewModel, vm => vm.SearchCustomerCommand, v => v.CustomerIdTextBox, nameof(CustomerIdTextBox.LostFocus)));
            d(this.OneWayBind(ViewModel, vm => vm.IsOccupied, v => v.AvailableZone.Visibility,
                IsOccupied => IsOccupied ? Visibility.Collapsed : Visibility.Visible));
            d(this.OneWayBind(ViewModel, vm => vm.Status, v => v.StatusTextBlock.Foreground, status => status == Room.RoomStatus.Available ? Brushes.Green : Brushes.LightYellow));
            d(this.OneWayBind(ViewModel, vm => vm.IsOccupied, v => v.OccupiedZone.Visibility,
                IsOccupied => IsOccupied ? Visibility.Visible : Visibility.Collapsed));
            d(this.OneWayBind(ViewModel, vm => vm.IsOccupied, v => v.RoomCard.Background, IsOccupied => IsOccupied ? Brushes.Red : Brushes.White));
            d(this.OneWayBind(ViewModel, vm => vm.Status, v => v.RoomCard.Background, status => status == Room.RoomStatus.Dirty ? Brushes.Gray : Brushes.White));
            d(this.OneWayBind(ViewModel, vm => vm.IsNewCustomer, v => v.CustomerIdTextBox.IsEnabled));
            d(this.OneWayBind(ViewModel, vm => vm.IsNewCustomer, v => v.CustomerNameTextBox.IsEnabled));
            d(this.OneWayBind(ViewModel, vm => vm.IsNewCustomer, v => v.BirthInfoStackPanel.IsEnabled));
            d(this.OneWayBind(ViewModel, vm => vm.IsNewCustomer, v => v.IdentityInfoStackPanel.IsEnabled));
            d(this.OneWayBind(ViewModel, vm => vm.IsNewCustomer, v => v.AddressInfoStackPanel.IsEnabled));
            d(ViewModel.AcceptCommand.Subscribe(_ => CustomerDialogHost.IsOpen = false));
            d(ViewModel.SearchCustomerCommand.Subscribe(_ => CustomerIdTextBox.IsEnabled = false));
        }

        public static DependencyProperty RoomProperty = DependencyProperty.Register("Room", typeof(Room), typeof(RoomControl));

        public Room Room
        {
            get => (Room)GetValue(RoomProperty);
            set => SetValue(RoomProperty, value);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (RoomControlViewModel)value; }
        }

        public RoomControlViewModel ViewModel
        {
            get { return (RoomControlViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(RoomControlViewModel), typeof(RoomControl));
    }
}