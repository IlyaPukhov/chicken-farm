namespace ChickenFarm.Notification
{
    public class EmailNotification : IDatabaseObserver
    {

        public void Notify(string message)
        {
            Console.WriteLine($"Email. " + message);
        }
    }
}
