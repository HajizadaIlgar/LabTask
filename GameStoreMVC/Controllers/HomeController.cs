using GameStoreMVC.DataAccess;
using GameStoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStoreMVC.Controllers
{
    public class HomeController(GameDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }
        public async Task<IActionResult> ProductDetails(int id)
        {
            return View(await _context.Games.FindAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> ProductDetails(int? id, GameVM vm)
        {
            if (id is null) return BadRequest();
            var data = await _context.Games.Where(x => x.Id == id).Select(x => x.ImageUrl).FirstOrDefaultAsync();

            if (data is null) return NotFound();
            return View(data);
        }
    }
}
