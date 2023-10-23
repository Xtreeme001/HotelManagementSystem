using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly DataContext _db;

        public GuestsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllguests() 
        {
            var guest = _db.Guests.ToList();
            return Ok(guest);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllguests(int id)
        {
            var guest = _db.Guests.FirstOrDefault(g => g.Id == id);
            if (guest == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(guest);
        }

        [HttpDelete("{int id}")]
        public IActionResult DeleteAllguests(int id)
        {
            var guest = _db.Guests.FirstOrDefault(g => g.Id == id);
            if (guest == null)
            {
                Console.WriteLine("Empty Field");
            }
            _db.Guests.Remove(guest);
            _db.SaveChanges();
            return Ok(guest);
        }


    }
}
