using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly DataContext _db;

        public StaffsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllstaffs()
        {
            var staff = _db.Staffs.ToList();
            return Ok(staff);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllstaffs(int id)
        {
            var staff = _db.Staffs.FirstOrDefault(s => s.Id == id);
            if (staff == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(staff);
        }
        [HttpDelete("{int id}")]
        public IActionResult DeleteAllstaffs(int id)
        {
            var staff = _db.Staffs.FirstOrDefault(s => s.Id == id);
            if (staff == null)
            {
                Console.WriteLine("Empty Field");
            }
            _db.Staffs.Remove(staff);
            _db.SaveChanges();
            return Ok(staff);
        }



    }
}
