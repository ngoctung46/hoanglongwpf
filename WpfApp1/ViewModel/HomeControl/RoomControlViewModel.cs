using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel.HomeControl
{
    public class RoomControlViewModel : ReactiveObject
    {
        private List<Customer> Customers;

        private Room _room;

        private Customer _customer;

        public ReactiveCommand<Unit, bool> SearchCustomerCommand { get; protected set; }

        public Room Room
        {
            get => _room;
            set => this.RaiseAndSetIfChanged(ref _room, value);
        }

        public Customer Customer
        {
            get => _customer;
            set => this.RaiseAndSetIfChanged(ref _customer, value);
        }

        public RoomControlViewModel(Room room)
        {
            Room = room;
            Customers = new List<Customer>()
            {
            new Customer{Id = 1, Uuid = "a1", Name="Test", IssuePlace = "Ho Chi Minh", Address = new Address{ApartmentNumber = "234", Line1 = "BHH Street", City = "Ho Chi Minh", Country = "Vietnam"}},
            new Customer{Id = 2, Uuid = "a2", Name="Test2", IssuePlace = "Ho Chi Minh1", Address = new Address{ApartmentNumber = "2343", Line1 = "BHH Street2", City = "Ho Chi Minh2", Country = "Vietnam2"}},
            new Customer{Id = 3, Uuid = "a3", Name="Test3", IssuePlace = "Ho Chi Minh2", Address = new Address{ApartmentNumber = "2344", Line1 = "BHH Street3", City = "Ho Chi Minh3", Country = "Vietnam3"}}
            };
            Customer = new Customer();
            SearchCustomerCommand = ReactiveCommand.Create(SearchCustomer);
        }

        private bool SearchCustomer()
        {
            if (Customer == null) Customer = new Customer();
            Customer = Customers.Where(x => x.Uuid == Customer.Uuid).FirstOrDefault();
            if (Customer == null) return false;
            return true;
        }
    }
}