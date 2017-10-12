using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using WpfApp1.Helper;
using WpfApp1.Model;
using WpfApp1.Repos;

namespace WpfApp1.ViewModel.OrderViewModels
{
    public class OrderControlViewModel : ReactiveObject
    {
        private readonly Room _room;
        private readonly ServiceRepo _serviceRepo;
        private readonly OrderlineRepo _orderlineRepo;
        private readonly CustomerRepo _customerRepo;
        public ReactiveList<Orderline> Orderlines { get; set; }
        public ReactiveCommand<Unit, Unit> CloseCommand { get; protected set; }
        public ReactiveCommand<Unit, Unit> CheckOutCommand { get; protected set; }

        public OrderControlViewModel(Room room)
        {
            _serviceRepo = new ServiceRepo();
            _orderlineRepo = new OrderlineRepo();
            _customerRepo = new CustomerRepo();
            _room = room;
            Orderlines = new ReactiveList<Orderline>();
            GetOrderInfo();
            CloseCommand = ReactiveCommand.Create(Close);
            CheckOutCommand = ReactiveCommand.CreateFromTask(CheckOut);
        }

        private void GetOrderInfo()
        {
            var checkInTime = _customerRepo.FindById(_room.CustomerId).CheckInDate;
            checkInTime = new DateTime(checkInTime.Year, checkInTime.Month, checkInTime.Day, 9, 15, 00);
            var fee = CalculateFee(checkInTime);
            if (_room == null) return;
            var orderlines = _orderlineRepo.FindByOrderId(_room?.OrderId);
            var orderTotal = 0.0;
            var orderQuantity = 0.0;
            var roomService = _serviceRepo.GetRoomRateService();
            if (roomService == null) return;
            roomService.CurrentPrice = _room.Rate;
            Orderlines.Add(new Orderline()
            {
                ServiceId = roomService.Id,
                Service = roomService,
                OrderId = _room.OrderId,
                Quantity = (int)fee / _room.Rate,
                Total = fee
            });
            orderTotal += fee;
            foreach (var orderline in orderlines)
            {
                var service = _serviceRepo.FindById(orderline?.ServiceId);
                if (orderline == null || service == null) continue;
                var ol = new Orderline
                {
                    ServiceId = orderline.ServiceId,
                    Service = service,
                    OrderId = orderline.OrderId,
                    Quantity = orderline.Quantity,
                    Total = orderline.Quantity * service.CurrentPrice
                };
                Orderlines.Add(ol);
                orderTotal += ol.Total;
                orderQuantity += ol.Quantity;
            }

            Orderlines.Add(new Orderline() { Service = new Service { Name = "TOTAL" }, Total = orderTotal, Quantity = orderQuantity });
        }

        private void Close()
        {
        }

        private async Task CheckOut()
        {
            await _orderlineRepo.Add(Orderlines[0]);
        }

        private double CalculateFee(DateTime checkInTime)
        {
            var checkOutTime = DateTime.Now;
            checkOutTime = new DateTime(checkOutTime.Year, checkOutTime.Month, checkOutTime.Day, 14, 30, 0);
            var stayedTime = checkOutTime.Subtract(checkInTime).TotalHours;
            if (stayedTime > 0 && stayedTime < 4) return CalculateHourlyFee(stayedTime);
            return CalculateDailyFee(checkInTime);
        }

        private double CalculateHourlyFee(double stayedTime)
        {
            if (stayedTime > 3.2) return _room.Type == Room.RoomType.Single ? 210_000 : 250_000;
            if (stayedTime > 2.2) return _room.Type == Room.RoomType.Single ? 190_000 : 240_000;
            if (stayedTime > 1.2) return _room.Type == Room.RoomType.Single ? 150_000 : 190_000;
            if (stayedTime > 0.2) return _room.Type == Room.RoomType.Single ? 100_000 : 150_000;
            return 0.0;
        }

        private double CalculateDailyFee(DateTime checkInTime)
        {
            var totalDay = 1;
            checkInTime = checkInTime.Hour <= 7 ?
                new DateTime(checkInTime.Year, checkInTime.Month, checkInTime.Day - 1, 12, 0, 0) :
                new DateTime(checkInTime.Year, checkInTime.Month, checkInTime.Day, 12, 0, 0);
            var checkOutTime = DateTime.Now;
            checkOutTime = new DateTime(checkOutTime.Year, checkOutTime.Month, checkOutTime.Day, 14, 30, 0);
            var stayedTime = checkOutTime.Subtract(checkInTime).TotalHours;
            totalDay += (int)stayedTime / 24;
            var totalHours = (int)stayedTime % 24;
            if (totalDay <= 1) return _room.Rate;
            if (totalHours > 4.2) return (totalDay + 1) * _room.Rate;
            return totalDay * _room.Rate + CalculateHourlyFee(totalHours);
        }
    }
}