using GameStoreMVC.DataAccess;
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
    }
}
