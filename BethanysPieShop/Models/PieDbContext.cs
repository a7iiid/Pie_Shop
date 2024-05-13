using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieDbContext:DbContext
    {
        public PieDbContext(DbContextOptions<PieDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Pie> pies { get; set; }    

    }

}
