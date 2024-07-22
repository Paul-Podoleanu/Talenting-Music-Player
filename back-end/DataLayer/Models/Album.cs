namespace back_end.DataLayer.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public Artist? Artist { get; set; }
        public List<int>? MusicFiles { get; set; }
    }
}
