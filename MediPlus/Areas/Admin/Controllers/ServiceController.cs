using MediPlus.DataAccess;
using MediPlus.Models;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController(MediplusDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Services.Include(s => s.Department).ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ServiceVM vM)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await _context.Departments.Where(x => !x.IsDeleted).FirstOrDefaultAsync();
                return View(vM);
            }
            if (!await _context.Departments.AnyAsync(x => x.Id == vM.DepartmentId && !x.IsDeleted))
            {
                ViewBag.Categories = await _context.Departments.Where(x => !x.IsDeleted).FirstOrDefaultAsync();
                return View(vM);
            }
            Service slider = new Service
            {
                Title = vM.Title,
                Description = vM.Description,
                Icon = vM.Icon,
                DepartmentId = vM.DepartmentId.Value,
            };
            await _context.Services.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Categories = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();
            if (id is null) return BadRequest();
            var Data = await _context.Services.FindAsync(id.Value);
            if (Data is null) return NotFound();
            return View(Data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, ServiceVM vm)
        {
            ViewBag.Categories = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();
            if (id is null) return BadRequest();
            var Data = await _context.Services.Where(y => y.Id == id).FirstOrDefaultAsync();
            if (Data is null) return NotFound();

            Data.Title = vm.Title;
            Data.Description = vm.Description;
            Data.Icon = vm.Icon;
            Data.DepartmentId = vm.DepartmentId.Value;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var MyData = await _context.Services.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (MyData is null) return NotFound();
            _context.Services.Remove(MyData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
