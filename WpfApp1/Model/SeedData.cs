using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public static class SeedData
    {
        public static List<Room> RoomSeedData
            => new List<Room>()
            {
                new Room()
                {
                    Name = "101",
                    Description = "Double Bed Room",
                    Type = Room.RoomType.Double,
                    Status = Room.RoomStatus.Available,
                    Rate = 400_000
                },
                new Room()
                {
                    Name = "102",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "103",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "104",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "201",
                    Description = "Double Bed Room",
                    Type = Room.RoomType.Double,
                    Status = Room.RoomStatus.Available,
                    Rate = 400_000
                },
                new Room()
                {
                    Name = "202",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "203",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "204",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "301",
                    Description = "Double Bed Room",
                    Type = Room.RoomType.Double,
                    Status = Room.RoomStatus.Available,
                    Rate = 400_000
                },
                new Room()
                {
                    Name = "302",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "303",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                },
                new Room()
                {
                    Name = "304",
                    Description = "Single Bed Room",
                    Type = Room.RoomType.Single,
                    Status = Room.RoomStatus.Available,
                    Rate = 300_000
                }
            };

        public static List<Service> ServiceSeedData
            => new List<Service>()
            {
                new Service()
                {
                    Name = "Giá Phòng",
                    CostPrice = 0.0,
                    CurrentPrice = 0.0,
                    Description = "Giá Phòng",
                    IsRoomRate = true
                }
            };
    }
}