namespace Snake.API.Models
{
    public class SnakeBoardDTO
    {
        public string apiversion { get; set; } = "1";
        public string author { get; set; } = "JinnFletch";
        public string color { get; set; } = "#0000FF";
        public string head { get; set; } = "default";
        public string tail { get; set; } = "default";
        public string version { get; set; } = "0.0.1-beta";
    }
}