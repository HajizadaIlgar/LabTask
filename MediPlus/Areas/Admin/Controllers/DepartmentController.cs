using MediPlus.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace MediPlus.Areas.Admin.Controllers
{
	public class DepartmentController(MediplusDbContext _context) : Controller
	{
		public async IActionResult Index()
		{
			return View();
		}
	}
}
