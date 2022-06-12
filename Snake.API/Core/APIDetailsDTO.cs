namespace Snake.API.Models
{
    public class APIDetailsDTO : DetailsDTO
    {
        public string apiversion { get; set; } = "1";
        public string author { get; set; } = "JinnFletch";
        public string version { get; set; } = "0.0.1-beta";
    }
}