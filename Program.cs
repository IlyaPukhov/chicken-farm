using ChickenFarm.Models;
using ChickenFarm.Notification;

namespace ChickenFarm
{
    public class Program
    {
        public static void Main()
        {
            SingletonDatabase db = SingletonDatabase.GetInstance();
            NotificationService notificationService = new();
            db.AddObserver(notificationService);

            db.UpdateChicken(new Chicken
            {
                Id = 1,
                Weight = 5.2F,
                Position = new Cell { Department = 1, Row = 1, Position = 1 },
                Breed = new Breed { Diet = 3 },
                Efficiency = 12
            });

            db.RemoveObserver(notificationService);
        }
    }
}
