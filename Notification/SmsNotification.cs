namespace ChickenFarm.Notification
{
    public class NotificationService : IDatabaseObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS. " + message);
        }
    }
}
