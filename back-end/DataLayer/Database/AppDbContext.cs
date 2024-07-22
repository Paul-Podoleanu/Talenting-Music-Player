using Microsoft.EntityFrameworkCore;
using back_end.DataLayer.Models;

namespace back_end.DataLayer.Database
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<MusicFile> MusicFiles { get; set; }
        public DbSet<Artist_MusicFile> Artist_MusicFiles { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
