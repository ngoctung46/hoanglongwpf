using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using WpfApp1.Model;
using WpfApp1.Model.Base;

namespace WpfApp1.Helper
{
    public static class Utility
    {
        private static readonly Action EmptyDelegate = delegate () { };

        public static Order CreateNewOrder(string customerId, string roomId, DateTime checkInDate)
        {
            return new Order() { CustomerId = customerId, RoomId = roomId, CheckInTime = checkInDate };
        }

        public static Orderline CreateNewOrderline(string serviceId, string orderId, double quantity, double price, string serviceName)
        {
            return new Orderline() { ServiceId = serviceId, ServiceName = serviceName, Quantity = quantity, OrderId = orderId, Price = price, Total = price * quantity };
        }

        public static void UpdateList<T>(ref List<T> list, T item) where T : ModelBase, new()
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Id == item.Id) list[i] = item;
            }
        }

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }

        public static UserControl GetParentForUserControl(UserControl control)
        {
            DependencyObject ucParent = control.Parent;

            while (ucParent != null && !(ucParent is UserControl))
            {
                ucParent = LogicalTreeHelper.GetParent(ucParent);
            }

            return (UserControl)ucParent;
        }

        public static void Print(UIElement control, string title)
        {
            PrintDialog dialog = new PrintDialog();

            if (dialog.ShowDialog() != true) return;

            control.Measure(new Size(dialog.PrintableAreaWidth, dialog.PrintableAreaHeight));
            control.Arrange(new Rect(new Point(20, 20),
                new Size(control.DesiredSize.Width + 50, control.DesiredSize.Height + 200)));
            dialog.PrintVisual(control, title);
        }

        public static List<string> GetProvinces()
        {
            return new List<string>()
            {
                "An Giang", "Bà Rịa Vũng Tàu", "Bạc Liêu", "Bắc Cạn", "Bắc Giang", "Bắc Ninh", "Bến Tre",
                "Bình Dương", "Bình Định", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Cần Thơ",
                "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang",
                "Hà Nam", "Hà Nội", "Hà Tây","Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hòa Bình", "Hồ Chí Minh", "Hậu Giang",
                "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lào Cai", "Lạng Sơn", "Lâm Đồng",
                "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam",
                "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa",
                "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"
            };
        }

        public static List<String> GetNations()
        {
            return new List<string>()
            {
                "Việt Nam",
                "Hàn Quốc",
                "Pháp",
                "Anh",
                "Ấn Độ",
                "Singapore",
                "Indonesia",
                "Thái Lan"
            };
        }
    }
}