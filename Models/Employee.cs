namespace ChickenFarm.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required List<Cell> Cells { get; set; }

        public float Salary { get; set; }
        public required DateTime HiringDate { get; set; }
        public DateTime? DismissalDate { get; set; }
    }
}
