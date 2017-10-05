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
    /// <summary>
    /// Interaction logic for IndexControl.xaml
    /// </summary>
    public partial class IndexControl : UserControl, IViewFor<IndexControlViewModel>
    {
        public IndexControl()
        {
            InitializeComponent();
            ViewModel = new IndexControlViewModel();
            this.WhenActivated(d => BindView(d));
        }

        private void BindView(Action<IDisposable> d)
        {
            d(ViewModel.InitializeCommand.Execute().Subscribe(_ => AddRooms()));
        }

        private void AddRooms()
        {
            if (ViewModel.Rooms == null || ViewModel.Rooms.Count == 0) return;
            foreach (var room in ViewModel.Rooms)
            {
                var roomControl = new RoomControl(room);
                RootWrapPanel.Children.Add(roomControl);
            }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IndexControlViewModel)value; }
        }

        public IndexControlViewModel ViewModel
        {
            get { return (IndexControlViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(IndexControlViewModel), typeof(IndexControl));
    }
}