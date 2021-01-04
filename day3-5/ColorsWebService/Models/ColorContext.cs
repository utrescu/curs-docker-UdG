using Microsoft.EntityFrameworkCore;

namespace Colors.Models
{
    public class ColorContext : DbContext
    {
        public ColorContext(DbContextOptions<ColorContext> options)
            : base(options)
        {
        }

        public DbSet<Color> Colors { get; set; }
    }
}