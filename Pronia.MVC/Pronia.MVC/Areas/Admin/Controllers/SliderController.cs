using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Contexts;

namespace Pronia.MVC.Areas.Admin.Controllers;
[Area("Admin")]
public class SliderController(ProniaDBContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await _context.SliderItems.ToListAsync());
    }
    public async Task<IActionResult> Create()
    {
        return View();
    }

}
