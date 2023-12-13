namespace ChickenFarm.Models
{
    public class Chicken
    {
        public int Id { get; set; }

        public float Weight { get; set; }

        public required Cell Position { get; set; }

        public required Breed Breed { get; set; }

        public int Efficiency { get; set; }
    }
}