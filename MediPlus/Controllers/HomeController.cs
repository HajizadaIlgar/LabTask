using MediPlus.DataAccess;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Controllers
{
	public class HomeController(MediplusDbContext _context) : Controller
	{
		public async Task<IActionResult> Index()
		{
			HomeItemVM vm = new HomeItemVM();
			vm.slideritem = await _context.Sliders.ToListAsync();
			vm.servicesitem = await _context.Services.ToListAsync();

			return View(vm);
		}

	}
}
