namespace Snake.API.Models
{
    public class SnakeRulesetDTO
    {
        public string name { get; set; }
        public string version { get; set; }
        public SnakeRuleSettingsDTO settings { get; set; }
    }
}