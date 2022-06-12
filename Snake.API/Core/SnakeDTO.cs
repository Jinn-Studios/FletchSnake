namespace Snake.API.Models
{
    public class SnakeDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public int health { get; set; }
        public List<xyDTO> body { get; set; }
        public string latency { get; set; }
        public xyDTO head { get; set; }
        public int length { get; set; }
        public string shout { get; set; }
        public string squad { get; set; }
        public DetailsDTO customizations { get; set; }
    }
}