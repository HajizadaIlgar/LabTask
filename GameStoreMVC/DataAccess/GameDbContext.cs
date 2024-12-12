using GameStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreMVC.DataAccess
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GameDbContext(DbContextOptions opt) : base(opt) { }
    }
}
