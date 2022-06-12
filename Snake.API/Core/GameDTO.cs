namespace Snake.API.Models
{
    public class GameDTO
    {
        public string id { get; set; }
        public RulesetDTO ruleset { get; set; }
        public string map { get; set; }
        public string source { get; set; }
        public int timeout { get; set; }
    }
}