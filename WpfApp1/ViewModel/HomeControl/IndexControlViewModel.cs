using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Repos;

namespace WpfApp1.ViewModel.HomeControl
{
    public class IndexControlViewModel : ReactiveObject
    {
        public ReactiveList<Room> Rooms;
        private RoomRepo _roomRepo;

        public ReactiveCommand<Unit, Unit> InitializeCommand { get; protected set; }

        public IndexControlViewModel()
        {
            _roomRepo = new RoomRepo();
            InitializeCommand = ReactiveCommand.Create(InitializeRooms);
        }

        private async void InitializeRooms()
        {
            var room = await _roomRepo.GetAsync();
            Rooms = new ReactiveList<Room>(room);
        }
    }
}