using MediPlus.DataAccess;
using MediPlus.Models;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class
		SliderController(MediplusDbContext _context, IWebHostEnvironment _env) : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View(await _context.Sliders.ToListAsync());
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(SliderVM vm)
		{
			if (!ModelState.IsValid) return View(vm);
			string newFileName = Path.GetRandomFileName() + Path.GetExtension(vm.File.FileName);

			using (Stream stream = System.IO.File.Create(Path.Combine(_env.WebRootPath, "imgs", newFileName)))
			{
				await vm.File.CopyToAsync(stream);
			}
			Slider slider = new Slider
			{
				Title = vm.Title,
				Description = vm.Description,
				ImageUrl = newFileName
			};
			await _context.Sliders.AddAsync(slider);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Update(int? id)
		{
			if (id is null) return BadRequest();
			var datas = await _context.Sliders.FindAsync(id.Value);
			if (datas is null) return BadRequest();
			return View(datas);
		}

		[HttpPost]
		public async Task<IActionResult> Update(int? id, Slider vm)
		{
			if (id == null) return BadRequest();
			var datas = await _context.Sliders.Where(x => x.Id == id).FirstOrDefaultAsync();
			if (datas is null) return NotFound();
			if (datas is not null)
			{
				datas.Title = vm.Title;
				datas.Description = vm.Description;
				datas.ImageUrl = vm.ImageUrl;

				_context.SaveChanges();
			}
			return RedirectToAction(nameof(Index));
		}
		public async Task<IActionResult> Delete(int? id)
		{
			if (id is null) return BadRequest();
			var data = await _context.Sliders.Where(x => x.Id == id).FirstOrDefaultAsync();
			if (data is null) return NotFound();
			string filepath = Path.Combine(_env.WebRootPath, "imgs");
			if (await _context.Sliders.AnyAsync(x => x.Id == id))
			{
				_context.Sliders.Remove(data);
				await _context.SaveChangesAsync();
			}
			return RedirectToAction(nameof(Index));
		}
	}
}
