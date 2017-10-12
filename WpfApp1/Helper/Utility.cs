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

        public static Order CreateNewOrder(string customerId, string roomId)
        {
            return new Order() { CustomerId = customerId, RoomId = roomId };
        }

        public static Orderline CreateNewOrderline(string serviceId, string orderId, double quantity)
        {
            return new Orderline() { ServiceId = serviceId, Quantity = quantity, OrderId = orderId };
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

            while (!(ucParent is UserControl))
            {
                ucParent = LogicalTreeHelper.GetParent(ucParent);
            }
            return ucParent as UserControl;
        }
    }
}