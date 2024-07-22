using back_end.DataLayer.Database;
using back_end.Repository;

namespace back_end.DataLayer.Database
{
    public class UnitOfWork : IDisposable
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            ArtistRepository = new ArtistRepository(context);
            AlbumRepository = new AlbumRepository(context);
            MusicFileRepository = new MusicFileRepository(context);
        }

        public ArtistRepository ArtistRepository { get; }
        public AlbumRepository AlbumRepository { get; }
        public MusicFileRepository MusicFileRepository { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
