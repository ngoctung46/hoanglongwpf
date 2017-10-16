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
using ReactiveUI;
using WpfApp1.ViewModel.ReportViewModels;

namespace WpfApp1.Controls.ReportControls
{
    /// <summary>
    /// Interaction logic for ReportIndexControl.xaml
    /// </summary>
    public partial class ReportIndexControl : UserControl, IViewFor<ReportIndexControlViewModel>
    {
        public ReportIndexControl()
        {
            InitializeComponent();
            ViewModel = new ReportIndexControlViewModel();
            DataContext = ViewModel;
            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel, vm => vm.Orders, v => v.ReportListView.ItemsSource));
                d(this.OneWayBind(ViewModel, vm => vm.Orders.Count, vm => vm.ReportListView.Visibility,
                    count => count > 0 ? Visibility.Visible : Visibility.Collapsed));
            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ReportIndexControlViewModel)value;
        }

        public ReportIndexControlViewModel ViewModel
        {
            get => (ReportIndexControlViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(ReportIndexControlViewModel), typeof(ReportIndexControl));

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}