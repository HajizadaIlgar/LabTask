using MediPlus.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Controllers
{
	public class HomeController(MediplusDbContext _context) : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View(await _context.Sliders.ToListAsync());
		}

	}
}
