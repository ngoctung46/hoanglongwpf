using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Helper;
using WpfApp1.Model;
using WpfApp1.Repos.Base;

namespace WpfApp1.Repos
{
    public class RoomRepo : RepoBase<Room>
    {
        private static List<Room> _rooms;

        public RoomRepo()
        {
            Task.Run(async () =>
            {
                var rooms = await All();
                _rooms = rooms.ToList();
            }).Wait();
        }

        public async Task<IEnumerable<Room>> All()
        {
            var rooms = await GetAsync();
            rooms = rooms.OrderBy(x => x.Name);
            return rooms;
        }

        public async Task<bool> Update(Room room)
        {
            var success = await PutAsync(room);
            if (success)
            {
                Utility.UpdateList(ref _rooms, room);
            }
            return success;
        }

        public List<Room> GetAll() => _rooms;

        public List<Room> AvailableRooms
            => _rooms.Where(x => x.Status == Room.RoomStatus.Available).ToList();
    }
}