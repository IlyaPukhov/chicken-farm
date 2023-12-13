namespace ChickenFarm.Notification
{
    public class EmailNotificationDecorator(IDatabaseObserver observer) : NotificationDecorator(observer)
    {
        public override void Notify(string message)
        {
            base.Notify(message);
            SendEmail(message);
        }

        private static void SendEmail(string message)
        {
            Console.WriteLine($"Email. " + message);
        }
    }
}
