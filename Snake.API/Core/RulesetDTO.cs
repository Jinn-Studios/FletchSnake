namespace Snake.API.Models
{
    public class RulesetDTO
    {
        public string name { get; set; }
        public string version { get; set; }
        public RuleSettingsDTO settings { get; set; }
    }
}