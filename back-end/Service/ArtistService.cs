using back_end.DataLayer.Database;
using back_end.DataLayer.Models;
using System.Collections.Generic;

namespace back_end.Service
{
    public class ArtistService
    {
        private readonly UnitOfWork _unitOfWork;

        public ArtistService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddArtist(Artist artist)
        {
            _unitOfWork.ArtistRepository.AddArtist(artist);
            _unitOfWork.SaveChanges();
        }

        public List<MusicFile> GetTopSongs(int artistId)
        {
            return _unitOfWork.ArtistRepository.GetTopSongs(artistId);
        }

        public List<Album> GetAlbums(int artistId)
        {
            return _unitOfWork.ArtistRepository.GetAlbums(artistId);
        }
    }
}
