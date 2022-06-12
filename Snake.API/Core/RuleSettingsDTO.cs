namespace Snake.API.Models
{
    public class RuleSettingsDTO
    {
        public int foodSpawnChance { get; set; }
        public int minimumFood { get; set; }
        public int hazardDamagePerTurn { get; set; }
        public RoyaleDTO royale { get; set; }
        public SquadDTO squad { get; set; }
    }
}