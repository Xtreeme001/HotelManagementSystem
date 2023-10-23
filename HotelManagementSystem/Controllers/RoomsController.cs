using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly DataContext _db;

        public RoomsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllrooms()
        {
            var room = _db.Rooms.ToList();
            return Ok(room);    
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllrooms(int id)
        {
            var room = _db.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(room);
        }

        [HttpDelete("{int id}")]
        public IActionResult DeleteAllrooms(int id)
        {
            var room = _db.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                Console.WriteLine("Empty Field");
            }
            _db.Rooms.Remove(room);
            _db.SaveChanges();
            return Ok(room);
        }
    }
}
