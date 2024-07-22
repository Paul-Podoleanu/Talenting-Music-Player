using back_end.DataLayer.Database;
using back_end.DataLayer.Models;
using System.Collections.Generic;

namespace back_end.Service
{
    public class AlbumService
    {
        private readonly UnitOfWork _unitOfWork;

        public AlbumService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddAlbum(Album album)
        {
            _unitOfWork.AlbumRepository.AddAlbum(album);
            _unitOfWork.SaveChanges();
        }

        public List<Album> GetAlbumsByArtist(int artistId)
        {
            return _unitOfWork.AlbumRepository.GetAlbumsByArtist(artistId);
        }
    }
}
