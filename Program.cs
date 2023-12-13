using ChickenFarm.Models;

namespace ChickenFarm
{
    public class Program
    {
        public static void Main()
        {
            SingletonDatabase db = SingletonDatabase.GetInstance();
            db.AddChicken(new Chicken
            {
                Weight = 5,
                Position = new Cell { Department = 1, Row = 1, Position = 1 },
                Breed = new Breed { Diet = 3 },
                Efficiency = 10
            });
        }
    }
}
