using ChickenFarm.Models;
using ChickenFarm.Notification;

namespace ChickenFarm
{
    public class Program
    {
        public static void Main()
        {
            SingletonDatabase db = SingletonDatabase.GetInstance();
            IDatabaseObserver emailNotification = new EmailNotification();
            db.AddObserver(emailNotification);

            db.UpdateChicken(new Chicken
            {
                Id = 1,
                Weight = 5.2F,
                Position = new Cell { Department = 1, Row = 1, Position = 1 },
                Breed = new Breed { Diet = 3 },
                Efficiency = 12
            });
            db.RemoveObserver(emailNotification);

            Console.WriteLine("---------- Замена нотифаера ----------");

            IDatabaseObserver emailSmsNotification = new SmsNotificationDecorator(emailNotification);
            db.AddObserver(emailSmsNotification);

            db.AddChicken(new Chicken
            {
                Weight = 4,
                Position = new Cell { Department = 1, Row = 2, Position = 8 },
                Breed = new Breed { Diet = 4 },
                Efficiency = 8
            });

            db.RemoveObserver(emailSmsNotification);
        }
    }
}
