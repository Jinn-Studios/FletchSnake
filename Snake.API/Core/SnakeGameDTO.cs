namespace Snake.API.Models
{
    public class SnakeGameDTO
    {
        public string id { get; set; }
        public SnakeRulesetDTO ruleset { get; set; }
        public string map { get; set; }
        public string source { get; set; }
        public int timeout { get; set; }
    }
}