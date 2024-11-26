using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;

namespace Pronia.MVC.DataAccess
{
    public class ProniaDbContext : DbContext
    {
        public DbSet<SliderItem> Sliders { get; set; }
        public ProniaDbContext(DbContextOptions opt) : base(opt) { }
    }
}
