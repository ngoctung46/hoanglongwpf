using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;
using WpfApp1.Controls.HomeControls;
using WpfApp1.Controls.ReportControls;
using WpfApp1.Model;

namespace WpfApp1.ViewModel.HomeViewModels
{
    public class MainWindowControlViewModel : ReactiveObject
    {
        public ReactiveList<MenuItem> Menu { get; set; }

        public MainWindowControlViewModel()
        {
            Menu = new ReactiveList<MenuItem>
            {
                new MenuItem() {Name = "Home", Content = new IndexControl()},
                new MenuItem() {Name = "Bookings"},
                new MenuItem() {Name = "Reports", Content = new ReportIndexControl(), MarginRequirement = new Thickness(16)},
                new MenuItem() {Name = "Settings"}
            };
        }
    }
}