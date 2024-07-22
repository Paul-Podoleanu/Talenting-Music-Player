namespace back_end.DataLayer.Models
{
    public class Artist_MusicFile
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int MusicFileId { get; set; }
        public Artist? Artist { get; set; }
        public MusicFile? MusicFile { get; set; }
        public int TopNumber { get; set; }
    }
}
