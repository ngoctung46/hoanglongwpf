using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using WpfApp1.Helper;
using WpfApp1.Model;
using WpfApp1.Repos;

namespace WpfApp1.ViewModel.ServiceControlViewModels
{
    public class ServiceControlViewModel : ReactiveObject
    {
        public ReactiveList<Service> Services;
        private readonly OrderlineRepo _orderlineRepo;
        private readonly ServiceRepo _serviceRepo;
        private double _price, _quantity = 1;
        private readonly ObservableAsPropertyHelper<double> _total;
        private Service _service = new Service();
        private readonly string _orderId;

        public ReactiveCommand<Unit, Unit> AddCommand { get; protected set; }
        public ReactiveCommand<Unit, Unit> CloseCommand { get; protected set; }

        public Service Service
        {
            get => _service;
            set => this.RaiseAndSetIfChanged(ref _service, value);
        }

        private string _serviceName;

        public string ServiceName
        {
            get => _serviceName;
            set => this.RaiseAndSetIfChanged(ref _serviceName, value);
        }

        public double Price
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value);
        }

        public double Quantity
        {
            get => _quantity;
            set => this.RaiseAndSetIfChanged(ref _quantity, value);
        }

        public double Total => _total.Value;

        public ServiceControlViewModel(string orderId)
        {
            _orderlineRepo = new OrderlineRepo();
            _serviceRepo = new ServiceRepo();
            GetServices();
            AddCommand = ReactiveCommand.CreateFromTask(AddAsync);
            _orderId = orderId;
            CloseCommand = ReactiveCommand.Create(Close);
            Service = Services[0];
            _total = this.WhenAnyValue(x => x.Price, y => y.Quantity, (x, y) => x * y).ToProperty(this, x => x.Total);
            this.WhenAnyValue(x => x.Service).Where(x => x != null).Select(x => x.CurrentPrice).BindTo(this, x => x.Price);
        }

        private void GetServices()
        {
            var services = _serviceRepo.GetAll();
            Services = new ReactiveList<Service>(services);
        }

        private async Task AddAsync()
        {
            if (Service == null)
            {
                var service = new Service() { Name = ServiceName, CurrentPrice = Price, CostPrice = Price };
                service.Id = await _serviceRepo.Add(service);
                Service = service;
            }
            var orderLine = Utility.CreateNewOrderline(Service.Id, _orderId, Quantity, Price, Service.Name);
            await _orderlineRepo.Add(orderLine);
        }

        private void Close()
        {
        }
    }
}