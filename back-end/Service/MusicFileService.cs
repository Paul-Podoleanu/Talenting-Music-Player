using back_end.DataLayer.Database;
using back_end.DataLayer.Models;

namespace back_end.Service
{
    public class MusicFileService
    {
        private readonly UnitOfWork _unitOfWork;

        public MusicFileService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddMusicFile(MusicFile musicFile)
        {
            _unitOfWork.MusicFileRepository.AddMusicFile(musicFile);
            _unitOfWork.SaveChanges();
        }

        public MusicFile GetMusicFileById(int id)
        {
            return _unitOfWork.MusicFileRepository.GetMusicFileById(id);
        }

        public IEnumerable<MusicFile> GetAllMusicFiles()
        {
            return _unitOfWork.MusicFileRepository.GetAllMusicFiles();
        }
    }
}