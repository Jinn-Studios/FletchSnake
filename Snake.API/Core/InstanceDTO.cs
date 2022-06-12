namespace Snake.API.Models
{
    public class InstanceDTO
    {
        public GameDTO game { get; set; }
        public int turn { get; set; }
        public BoardInstanceDTO board { get; set; }
        public SnakeDTO you { get; set; }
    }
}