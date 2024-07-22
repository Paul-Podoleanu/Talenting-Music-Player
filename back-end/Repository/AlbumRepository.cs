using back_end.DataLayer.Database;
using back_end.DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace back_end.Repository
{
    public class AlbumRepository
    {
        private readonly AppDbContext _context;

        public AlbumRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public List<Album> GetAlbumsByArtist(int artistId)
        {
            return _context.Albums.Where(a => a.Artist.Id == artistId).ToList();
        }
    }
}
