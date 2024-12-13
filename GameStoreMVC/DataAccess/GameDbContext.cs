using GameStoreMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStoreMVC.DataAccess
{
    public class GameDbContext : IdentityDbContext<User>
    {
        public DbSet<Game> Games { get; set; }
        public GameDbContext(DbContextOptions opt) : base(opt) { }
    }
}
