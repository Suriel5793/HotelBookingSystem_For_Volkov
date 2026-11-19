using System.Collections.Generic;

namespace Diplom.Models
{
    public static class DataStore
    {
        public static List<HotelRoom> Rooms { get; set; } = new List<HotelRoom>();
        public static List<Booking> Bookings { get; set; } = new List<Booking>();
        public static int NextRoomId { get; set; } = 1;
        public static int NextBookingId { get; set; } = 1;
        public static double LastLambda { get; set; } = 45;
        public static double LastMu { get; set; } = 0.5;
        public static int LastC { get; set; } = 100;
        public static User CurrentUser { get; set; }
    }
}