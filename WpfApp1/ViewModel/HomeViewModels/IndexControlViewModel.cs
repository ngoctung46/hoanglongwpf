using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;
using WpfApp1.Repos;

namespace WpfApp1.ViewModel.HomeViewModels
{
    public class IndexControlViewModel : ReactiveObject
    {
        public ReactiveList<Room> Rooms;
        private readonly RoomRepo _roomRepo;

        public ReactiveCommand<Unit, bool> InitializeCommand { get; protected set; }

        public IndexControlViewModel()
        {
            _roomRepo = new RoomRepo();
            InitializeCommand = ReactiveCommand.CreateFromTask(InitializeRooms);
        }

        private async Task<bool> InitializeRooms()
        {
            var app = ((App)Application.Current);
            if (app.Rooms != null) return false;
            var rooms = await _roomRepo.All();
            Rooms = new ReactiveList<Room>(rooms);
            app.Rooms = Rooms;
            return true;
        }
    }
}