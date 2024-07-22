using back_end.DataLayer.Database;
using back_end.DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace back_end.Repository
{
    public class ArtistRepository
    {
        private readonly AppDbContext _context;

        public ArtistRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public List<MusicFile> GetTopSongs(int artistId)
        {
            return _context.Artist_MusicFiles
                .Where(amf => amf.ArtistId == artistId)
                .OrderByDescending(amf => amf.TopNumber)
                .Select(amf => amf.MusicFile)
                .Take(5)
                .ToList();
        }

        public List<Album> GetAlbums(int artistId)
        {
            return _context.Albums.Where(a => a.Artist.Id == artistId).ToList();
        }
    }
}
