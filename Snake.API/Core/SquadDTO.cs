namespace Snake.API.Models
{
    public class SquadDTO
    {
        public bool allowBodyCollisions { get; set; } = true;
        public bool sharedElimination { get; set; } = true;
        public bool sharedHealth { get; set; } = true;
        public bool sharedLength { get; set; } = true;
    }
}