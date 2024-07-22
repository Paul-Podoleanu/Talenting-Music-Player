using back_end.DataLayer.Database;
using back_end.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace back_end.Repository
{
    public class MusicFileRepository
    {
        private readonly AppDbContext _context;

        public MusicFileRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddMusicFile(MusicFile musicFile)
        {
            _context.MusicFiles.Add(musicFile);
            _context.SaveChanges();
        }

        public MusicFile GetMusicFileById(int id)
        {
            return _context.MusicFiles.Find(id);
        }

        public IEnumerable<MusicFile> GetAllMusicFiles()
        {
            return _context.MusicFiles.ToList();
        }
    }
}
