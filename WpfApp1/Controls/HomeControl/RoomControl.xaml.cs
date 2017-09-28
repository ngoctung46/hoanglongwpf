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
    internal enum RoomStatus
    {
        Occupied,
        Available,
        Dirty,
        Clean,
        Broken,
        CustomerOut,
        Booked
    }

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
            d(this.BindCommand(ViewModel, vm => vm.SearchCustomerCommand, v => v.CustomerIdTextBox, "LostFocus"));
            d(ViewModel.SearchCustomerCommand.Subscribe(IsSuccess => { if (IsSuccess) DisableAllControls(); }));
        }

        private void DisableAllControls()
        {
            CustomerIdTextBox.IsEnabled = false;
            CustomerNameTextBox.IsEnabled = false;
            BirthInfoStackPanel.IsEnabled = false;
            AddressInfoStackPanel.IsEnabled = false;
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