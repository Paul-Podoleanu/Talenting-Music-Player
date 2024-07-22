namespace back_end.DataLayer.Models
{
    public class MusicFile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int Rating { get; set; }
        public string? Image { get; set; }
        public string? Path { get; set; }
        public string? Lenght { get; set; }
    }
}
