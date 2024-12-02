using MediPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.DataAccess
{
	public class MediplusDbContext : DbContext
	{
		public DbSet<Slider> Sliders { get; set; }
		public MediplusDbContext(DbContextOptions opt) : base(opt) { }
	}
}
