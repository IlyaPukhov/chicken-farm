namespace ChickenFarm.Models
{
    public class Cell
    {
        public int Id { get; set; }

        public int Department { get; set; }

        public int Row { get; set; }

        public int Position { get; set; }

        public string GetString() => $"{Department}-{Row}-{Position}";
    }
}
