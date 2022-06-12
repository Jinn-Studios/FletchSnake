namespace Snake.API.Models
{
    public class SnakeInstanceDTO
    {
        public SnakeGameDTO game { get; set; }
        public int turn { get; set; }
        public SnakeBoardInstanceDTO board { get; set; }
        public SnakeDTO you { get; set; }
    }
}