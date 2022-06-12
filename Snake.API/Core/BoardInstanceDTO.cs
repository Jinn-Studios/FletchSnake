namespace Snake.API.Models
{
    public class BoardInstanceDTO
    {
        public int height { get; set; }
        public int width { get; set; }
        public List<xyDTO> food { get; set; }
        public List<xyDTO> hazards { get; set; }
        public List<SnakeDTO> snakes { get; set; }
    }
}