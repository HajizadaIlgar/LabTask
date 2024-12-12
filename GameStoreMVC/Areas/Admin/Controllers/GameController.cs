using GameStoreMVC.DataAccess;
using GameStoreMVC.Models;
using GameStoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GameController(GameDbContext _context, IWebHostEnvironment _env) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(GameVM vm)
        {
            if (!ModelState.IsValid) return View(vm);
            string newFilename = Path.GetRandomFileName() + Path.GetExtension(vm.File.FileName);
            using (Stream stream = System.IO.File.Create(Path.Combine(_env.WebRootPath, "gamephotos", newFilename)))
            {
                await vm.File.CopyToAsync(stream);
            }
            Game game = new Game
            {
                GameName = vm.GameName,
                ImageUrl = newFilename,
                SellPrice = vm.SellPrice,
                CostPrice = vm.CostPrice,
                Discount = vm.Discount,
                GameId = vm.GameId,
            };
            await _context.AddAsync(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();
            var data = await _context.Games.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data is null) return NotFound();
            _context.Games.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ProductDetails(int? id, GameVM vm)
        {
            if (id is null) return BadRequest();
            var data = await _context.Games.Where(x => x.Id == id).Select(x => x.ImageUrl).FirstOrDefaultAsync();

            if (data is null) return NotFound();
            return View(data);
        }
    }
}
