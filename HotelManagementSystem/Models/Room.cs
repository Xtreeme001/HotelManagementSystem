namespace HotelManagementSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string RoomType { get; set; }    
        public bool IsAvailable { get; set; }
    }
}
