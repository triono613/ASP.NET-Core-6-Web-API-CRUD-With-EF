using Microsoft.EntityFrameworkCore;
using trionoNetCoreAPI.Models;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ConnContext: DbContext
    {
        public ConnContext(DbContextOptions options) : base(options) { }
        public DbSet<Contacs> Contacs { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
