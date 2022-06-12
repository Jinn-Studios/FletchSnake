namespace Snake.API.Models
{
    public class SnakeRuleSettingsDTO
    {
        public int foodSpawnChance { get; set; }
        public int minimumFood { get; set; }
        public int hazardDamagePerTurn { get; set; }
        public SnakeRoyaleDTO royale { get; set; }
        public SnakeSquadDTO squad { get; set; }
    }
}