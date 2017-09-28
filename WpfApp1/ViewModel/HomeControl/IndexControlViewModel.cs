using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel.HomeControl
{
    public class IndexControlViewModel : ReactiveObject
    {
        public ReactiveList<Room> Rooms;

        public IndexControlViewModel()
        {
            InitializeRooms();
        }

        private void InitializeRooms()
        {
            Rooms = new ReactiveList<Room>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Rooms.Add(new Room
                    {
                        Id = i + j,
                        Number = int.Parse($"{i + 1}0{j + 1}"),
                        Description = j == 0 ? "Double Bed Room" : "Single Bed Room",
                        Price = j == 0 ? 400.0 : 300.0
                    });
                }
            }
        }
    }
}