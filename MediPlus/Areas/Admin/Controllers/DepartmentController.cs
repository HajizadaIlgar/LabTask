using MediPlus.DataAccess;
using MediPlus.Models;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController(MediplusDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departments.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Department dp = new Department
            {
                Name = vm.Name,
            };
            await _context.Departments.AddAsync(dp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();
            var data = await _context.Departments.Where(z => z.Id == id).FirstOrDefaultAsync();
            if (data is null) return NotFound();
            _context.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
