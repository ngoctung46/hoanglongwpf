using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel.HomeControl
{
    public class RoomControlViewModel : ReactiveObject
    {
        private List<Customer> Customers;

        private Room _room;

        private Room.RoomStatus _status;

        private Customer _customer;

        private readonly ObservableAsPropertyHelper<bool> _isOccupied;

        private bool _isNewCustomer = true;

        public ReactiveCommand<Unit, bool> SearchCustomerCommand { get; protected set; }
        public ReactiveCommand<Unit, Unit> AcceptCommand { get; protected set; }
        public ReactiveCommand<Unit, Unit> CheckOutCommand { get; protected set; }
        public ReactiveCommand<Unit, Unit> CleaningCommand { get; protected set; }
        public bool IsOccupied => _isOccupied.Value;

        public Room Room
        {
            get => _room;
            set => this.RaiseAndSetIfChanged(ref _room, value);
        }

        public Room.RoomStatus Status
        {
            get => _status;
            set => this.RaiseAndSetIfChanged(ref _status, value);
        }

        public Customer Customer
        {
            get => _customer;
            set => this.RaiseAndSetIfChanged(ref _customer, value);
        }

        public bool IsNewCustomer
        {
            get => _isNewCustomer;
            set => this.RaiseAndSetIfChanged(ref _isNewCustomer, value);
        }

        public RoomControlViewModel(Room room)
        {
            Room = room;
            Status = Room.Status;
            Customer = new Customer();
            Customers = new List<Customer>()
            {
            new Customer{Id = 1, Uuid = "a1", Name="Test", IssuePlace = "Ho Chi Minh", Address = new Address{ApartmentNumber = "234", Line1 = "BHH Street", City = "Ho Chi Minh", Country = "Vietnam" }},
            new Customer{Id = 2, Uuid = "a2", Name="Test2", IssuePlace = "Ho Chi Minh1", Address = new Address{ApartmentNumber = "2343", Line1 = "BHH Street2", City = "Ho Chi Minh2", Country = "Vietnam2"}},
            new Customer{Id = 3, Uuid = "a3", Name="Test3", IssuePlace = "Ho Chi Minh2", Address = new Address{ApartmentNumber = "2344", Line1 = "BHH Street3", City = "Ho Chi Minh3", Country = "Vietnam3"}}
            };
            SearchCustomerCommand = ReactiveCommand.Create(SearchCustomer);
            AcceptCommand = ReactiveCommand.Create(Accept);
            CheckOutCommand = ReactiveCommand.Create(CheckOut);
            CleaningCommand = ReactiveCommand.Create(Cleaning);
            _isOccupied = this.WhenAnyValue(x => x.Status, s => s != Room.RoomStatus.Available).ToProperty(this, x => x.IsOccupied);
        }

        private bool SearchCustomer()
        {
            string uuid = Customer.Uuid;
            Customer = Customers.Where(x => x.Uuid == uuid).FirstOrDefault();
            if (Customer == null)
            {
                IsNewCustomer = true;
                Customer = new Customer() { Uuid = uuid };
                return false;
            }
            else
            {
                IsNewCustomer = false;
                return true;
            }
        }

        private void Accept()
        {
            Room.Status = Room.RoomStatus.Occupied;
            Status = Room.Status;
            Console.WriteLine($"Customer Info: {Customer.Name} - {Customer.Uuid} - {Customer.BirthDate} - {Customer.BirthPlace} - {Customer.Address.Line1} - {Customer.Address.Line2} - {Customer.Address.City} - {Customer.Address.Country}");
        }

        private void CheckOut()
        {
            Room.Status = Room.RoomStatus.Dirty;
            Status = Room.Status;
            Customer = new Customer();
        }

        private void Cleaning()
        {
            IsNewCustomer = true;
            Room.Status = Room.RoomStatus.Available;
            Status = Room.Status;
        }
    }
}